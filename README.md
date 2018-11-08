# szkola_chmury

żeby zaimplementować plik json w zadaniu 3.3 użyłem polecenia w powershell :
New-AzureRmRoleDefinition -InputFile "C:\CustomRoles\custom_role.json"

w zadaniu 3.2 użyłem polecenia powershell:
New-AzureRmResourceGroup -Name "prb-tst-rg-01" -Location 'West Europe'

$deploy="prbdeployment"
$RGName="prb-tst-rg-01"
$template="C:\Github\vm_template.json"

New-AzureRmResourceGroupDeployment -Name $deploy -ResourceGroupName $RGName -TemplateFile $template


w zadaniu 3.4 żeby utworzyć AVK użyłem polecenia :
New-AzureRmKeyVault -VaultName 'prb-tst-keyv-01' -ResourceGroupName 'prb-tst-rg-01' -Location 'West Europe'

