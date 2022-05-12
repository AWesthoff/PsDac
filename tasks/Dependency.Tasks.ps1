task InstallBuildDependencies -Jobs {
    Install-Module platyPs -Scope CurrentUser -ErrorAction Stop -Verbose
}

task InstallTestDependencies -Jobs {
    Install-Module Pester -MinimumVersion '5.0.0'
    Install-Module PsSqlLocalDb -Scope CurrentUser -ErrorAction Stop -Verbose -AllowPrerelease
    Install-Module PsSqlTestServer -Scope CurrentUser -ErrorAction Stop -Verbose -AllowPrerelease
    Install-Module PsSqlClient -Scope CurrentUser -ErrorAction Stop -Verbose -MaximumVersion 0.4.0
    Install-Module PsSmo -Scope CurrentUser -ErrorAction Stop -Verbose -AllowPrerelease
    Install-Module Invoke-MsBuild -ErrorAction Stop
}, TestData.Create

task InstallReleaseDependencies -Jobs {}
