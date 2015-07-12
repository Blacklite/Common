@echo off
$ENV:DNX_FEED='https://www.nuget.org/api/v2'
if (!(Get-Command dvnm)) {
    $Branch='dev';
    iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'));

    $ENV:PATH="$ENV:PATH;$ENV:USERPROFILE\.dnx\bin";
    $ENV:DNX_HOME="$ENV:USERPROFILE\.dnx";
}

dnvm install 1.0.0-beta5
dnvm use 1.0.0-beta5
$ENV:PATH="$ENV:USERPROFILE\.dnx\runtimes\dnx-clr-win-x86.1.0.0-beta5\bin;$ENV:PATH"

var $configuration="Debug"
$ENV:DNX_BUILD_VERSION="alpha"

if ($ENV:APPVEYOR) {
    IF ($ENV:APPVEYOR_REPO_TAG -eq "false" -or $ENV:APPVEYOR_REPO_TAG -eq "False") {
        if ($ENV:APPVEYOR_REPO_BRANCH -eq "master") {
            $ENV:DNX_BUILD_VERSION="ci-$ENV:APPVEYOR_BUILD_NUMBER";
        } else {
            $ENV:DNX_BUILD_VERSION="branch-$ENV:APPVEYOR_REPO_BRANCH-$ENV:APPVEYOR_BUILD_NUMBER";
        }
    }
    IF ($ENV:APPVEYOR_REPO_TAG -eq "true" -or $ENV:APPVEYOR_REPO_TAG -eq "True") {
        $ENV:DNX_BUILD_VERSION=$ENV:APPVEYOR_BUILD_NUMBER
    }
}

echo DNX_BUILD_VERSION: $ENV:DNX_BUILD_VERSION

dnu restore
if (!($?)) exit /b $LASTEXITCODE

$testsFailed = $false;
foreach ($testFolder in Get-ChildItem test\* -Directory) {
    pushd $testFolder.FullName
    dnx . test.
    if (!($?)) $testsFailed = $true;
    popd
}

if ($testsFailed) {
    exit;
}

foreach ($srcFolder in Get-ChildItem test\* -Directory) {
    dnu pack $srcFolder.FullName --out artifacts\build --configuration $configuration
}

foreach ($item in Get-ChildItem artifacts\build\$configuration\*.nupkg) {
    copy $item.FullName artifacts\build
)

mkdir artifacts\symbols

foreach ($item in Get-ChildItem artifacts\build\$configuration\*.symbols.nupkg) {
    copy $item.FullName artifacts\symbols
}

popd
