# .NET API Template

[TODO] Intro

* Create simple .NET API
  * This simple API is created using ``dotnet new webapi``
* Dockerize it
* CI/CD pipeline (GitHub Actions) to build image and upload to Docker Hub
  * Workflow created using GitHub Action's default template for creating a Docker container, then expanded

## Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/en-us/download) (.NET 7.0 used here as of July 2023)
* [Docker Desktop](https://docs.docker.com/desktop/install/windows-install/) and a [Docker Hub](https://hub.docker.com/) account

[TODO] Doc/setup etc.

## Test locally

* Clone/fork project
* In root folder, open terminal and run:
  * ``dotnet run``
  * Check http://localhost:5010/weatherforecast

To build a Docker-image, in root folder, open terminal and run:
* ``docker build -t <YOUR_DOCKER_USERNAME>/dotnet-api-template .``

To run image, open terminal and run:
* ``docker run --name dotnet-api-template -dp 5010:5010 <YOUR_DOCKER_USERNAME>/dotnet-api-template``
* Check http://localhost:5010/weatherforecast

## CI/CD with GitHub Actions

[TODO] Doc/setup etc.