# .NET API Template with GitHub, Docker & Azure CI/CD & IaC

### Here are the steps I took to achieve my results
Got the base code:
  - forked reza's dotnet-api-template too my github
  - Cloned it with visual studio code
  - ran the code localy to check if everything works ``dotnet run``

#### Build, run, push to docker
  - build the app in docker via terminal, using ``docker build -t markenden/dotnet-api-template .``
  - ran the docker localy via terminal, using ``docker run --name dotnet-api-template -dp 5010:80 <markenden/dotnet-api-template``
  - pushed the app to hub.docker

#### Made the docker/github CI/CD
  - made access token in docker
  - added secrets for username and docker access token in github repository
  - updated/pushed my repository to see if it worked, had to activate actions in github, since it blocked it at first. Worked fine afterwards.

#### Added the bicep files, made the resource group, app service & app service plan
  - took the bicep files from "ci-cd-iac-bicep", and ajusted some info (I did in the old files, not this one)
  - added all the local info to terminal:
  
  ``$ENV:ARM_CLIENT_ID = "668ccd6f-6d36-426e-b1a7-c158ac48d596"``

  ``$ENV:ARM_CLIENT_SECRET = "****************************************"``

  ``$ENV:ARM_SUBSCRIPTION_ID = "c8866fbf-71d6-4235-91cd-201c29ec1b0e"``

  ``$ENV:ARM_TENANT_ID = "a1d168fb-cc80-4836-8881-3ab4a0cd4630"``

  ``$env:AZURE_REGION = "NorthEurope"``

  ``$env:RG_NAME = "rg-bicep-webapp-mark"``

  ``$env:DOCKER_USR = "markenden"``

  ``$env:DOCKER_IMAGE = "dotnet-api-template"``

  - "cd infrastructure" to relevent map -> ran the command to build the Rg, app & app service plan (first as what-if to be sure)

   ``az deployment sub what-if -l ${env:AZURE_REGION} --name=rg-bicep-webapp-mark --template-file main.bicep --parameters rgName=${env:RG_NAME} location=${env:AZURE_REGION} dockerHubUser=${env:DOCKER_USR} dockerImage=${env:DOCKER_IMAGE}``

#### Add a webhook to docker
  - Asked Reza to make a webhook url for me since I did not have the privilege for that, and added it to the docker repo

#### Cleaned up a little
  - trew away the old bicep files
  - made this readme

#### Screenshots are added in the screenshots map in the .zip that I'll upload to Noroff Accelerate

#### final thoughts
Looking back and seeing it all written out it seems so simple, yet it took me a couple of tries and experimentations to get it right :D
At first I was overwhelmed with all the possibilities and uncertainties but it ended up being more straight foreward than I anticipated, nice.

Thank you again and have a nice day!