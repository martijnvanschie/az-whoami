# Azure Who Am I

## What does it do

Azure Who Am I is a small wrapper around various Azure CLI (`az`) command which give information about your current logged in account for Azure CLI.

## Installation

Just download the executable from the [releases](https://github.com/martijnvanschie/az-whoami/releases) page. Put in a (shared) folder and add the folder to your PATH variable. Then just run `azwhoami`.

Currently only a preview version is available which is a win-64 release build. 

**Note:** `azwhoami` required .Net 7 to be installed on your machine. It also works with Azure CLI which ofcourse is also required.

## So waht do i get

The command line will print various kinds of information related to your account. Depending on your account type (user|service principal) you will get other information.

Below is an example of my user account which i used for work :)

![Drag Racing](./img/example.png)