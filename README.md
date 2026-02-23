# Azure Who Am I

![GitHub tag (latest by date)](https://img.shields.io/github/v/tag/martijnvanschie/az-whoami?label=Latest%20Release&logo=github)
![GitHub Release Date](https://img.shields.io/github/release-date/martijnvanschie/az-whoami?logo=github)
![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/martijnvanschie/az-whoami/ci.yml?label=CI%20Build)

## What does it do

Azure Who Am I is a small wrapper around various Azure CLI (`az`) command which give information about your current logged in account for Azure CLI.

## Prerequisites

**Azure CLI**  
Download the CLI from the download page [Azure Command-Line Interface](https://learn.microsoft.com/en-us/cli/azure/)

**.Net 10.0**  
The code is running on .Net 10.0 which can be downloaded here at [.NET 10.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) download site.

**Azure CLI account extension**  
`az extension add --name account`

## Installation

Just download the executable from the [releases](https://github.com/martijnvanschie/az-whoami/releases) page. Put in a (shared) folder and add the folder to your PATH variable. Then just run `azwhoami`.

Currently only a win-64 release build is available.

> The Program database (.pdb) are not required to run the cli.

## So what do i get

The command line will print various kinds of information related to your account. Depending on your account type (user|service principal) you will get other information.

Below is an example of my personal Azure user account :)

![Drag Racing](./img/example.png)
