# Adorable_CI_CD_Pipeline_Code
steps:
- task: azure-pipelines.yml
  displayName: 'Remove unneeded files'
  inputs:
    contents: |
      some/file
      test*
      **/bin/*
