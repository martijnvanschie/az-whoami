// See https://aka.ms/new-console-template for more information
using AzWhoAmI.ConsoleApp;
using Azure.Cli.Commands;
using Azure.Cli.Commands.Ad;
using Spectre.Console;

const string URL_EXTENSIONS = "https://learn.microsoft.com/en-us/cli/azure/azure-cli-extensions-overview";

var image = new CanvasImage(AzWhoAmI.ConsoleApp.Properties.Resources.azure_logo);
image.MaxWidth(26);
AnsiConsole.Write(image);

var extentions = await ExtensionCommands.ListServicePrincipalsAsync();
if (extentions.Any(e => e.Name.Equals("account")) == false)
{
    var config = await ConfigCommands.GetConfigAsync();
    if (config is null)
    {
        AnsiConsole.MarkupLine("[red]Unable to read Azure CLI config.[/]");
        Environment.Exit(-1);
    }

    if (config.Extension is null)
    {
        AnsiConsole.MarkupLine($"[{Color.Gold1}]The required extension 'account' is not installed and no extension config was found.[/]");
        AnsiConsole.MarkupLine($"Please visit [link blue]{URL_EXTENSIONS}[/] for more info.");
        Environment.Exit(-1);
    }

    var e = config.Extension.FirstOrDefault(e => e.Name.Equals("use_dynamic_install"));
    if (e is null)
    {
        AnsiConsole.MarkupLine($"[{Color.Gold1}]The required extension 'account' is not installed and the config setting 'use_dynamic_install' was not found.[/]");
        AnsiConsole.MarkupLine($"Please visit [link blue]{URL_EXTENSIONS}[/] for more info.");
        Environment.Exit(-1);
    }

    if (e.Value.Equals("yes_without_prompt") == false)
    {
        AnsiConsole.MarkupLine("[red]The required extension 'account' was not found and 'use_dynamic_install' is not set to 'yes_without_prompt'.[/]");
        Environment.Exit(-1);
    }

    AnsiConsole.MarkupLine($"[{Color.Blue}]The required extension 'account' was not found but 'use_dynamic_install' is set to 'yes_without_prompt'. It will be installed automatically.[/]");
}

await OutputProvider.PrintCurrentAccountAsync();
AnsiConsole.MarkupLine("");

await OutputProvider.PrintTenantsAsync();
AnsiConsole.MarkupLine("");

await OutputProvider.PrintDomainsAsync();
AnsiConsole.MarkupLine("");

await OutputProvider.PrintSubscriptionsAsync();

AnsiConsole.MarkupLine("");
AnsiConsole.MarkupLine("Find the latest version at:");
AnsiConsole.MarkupLine("[link blue]https://github.com/martijnvanschie/az-whoami[/]");
