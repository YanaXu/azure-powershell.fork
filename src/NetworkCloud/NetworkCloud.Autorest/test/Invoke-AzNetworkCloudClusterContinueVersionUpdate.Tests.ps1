if(($null -eq $TestName) -or ($TestName -contains 'Invoke-AzNetworkCloudClusterContinueVersionUpdate'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-AzNetworkCloudClusterContinueVersionUpdate.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-AzNetworkCloudClusterContinueVersionUpdate' {
    It 'ContinueExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Continue' {
        $expectedErrorMessage = "cluster $($global:config.AzNetworkCloudCluster.continueUpdateVersionClusterName) does not have suitable conditions to continue to update"
        { 
            Invoke-AzNetworkCloudClusterContinueVersionUpdate `
                -ResourceGroupName $global:config.AzNetworkCloudCluster.continueUpdateVersionClusterRg `
                -ClusterName $global:config.AzNetworkCloudCluster.continueUpdateVersionClusterName `
                -SubscriptionId $global:config.AzNetworkCloudCluster.subscriptionId `
                -MachineGroupTargetingMode "AlphaByRack" 
        } | Should -Throw
        $Error[0].Exception.Message | Should -Match $expectedErrorMessage
    }

    It 'ContinueViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ContinueViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
