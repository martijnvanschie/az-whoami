using Azure.Cli.Commands;
using Azure.Cli.Commands.Ad;
using CliWrap.Exceptions;
using Spectre.Console;

namespace AzWhoAmI.ConsoleApp
{
    internal class OutputProvider
    {
        static Color c1 = Color.Gold1;

        static AccountCommands accountCommand = new();
        static AdCommands sps = new();

        public static async Task PrintCurrentAccountAsync()
        {
            await AnsiConsole.Status()
                .StartAsync("Getting current account...", async ctx =>
                {
                    var account = await accountCommand.ShowAccountAsync();
                    AnsiConsole.MarkupLineInterpolated($"[gold1]You are current logged in with a {account.User.Type} account[/]");

                    switch (account.User.Type.ToLower())
                    {
                        case "user":
                            var user = await sps.GetSignedInUserAsync();
                            var table = new Table();
                            table.Border(TableBorder.None);
                            table.AddColumns("Id", "Property", "Value");
                            table.AddRow(string.Empty, "Id", $": {user.Id}");
                            table.AddRow(string.Empty, "User Principal Name", $": {user.UserPrincipalName}");
                            table.AddRow(string.Empty, "User Name", $": {user.DisplayName}");
                            table.Columns[0].Width(7);
                            table.HideHeaders();
                            AnsiConsole.Write(table);
                            break;
                        case "serviceprincipal":
                            var sp = await sps.GetServicePrincipalAsync(account.User.Name);
                            var table1 = new Table();
                            table1.Border(TableBorder.None);
                            table1.AddColumns("Id", "Property", "Value");
                            table1.AddRow(string.Empty, "Id", $": {sp.Id}");
                            table1.AddRow(string.Empty, "App Id", $": {sp.AppId}");
                            table1.AddRow(string.Empty, "Display Name", $": {sp.DisplayName}");
                            table1.Columns[0].Width(7);
                            table1.HideHeaders();
                            AnsiConsole.Write(table1);
                            break;
                        default:
                            break;
                    }
                });
        }

        public static async Task PrintTenantsAsync()
        {
            await AnsiConsole.Status()
                .StartAsync("Getting tenants for current account...", async ctx =>
                {
                    AnsiConsole.MarkupLine($"[gold1]You have access to the following tenants[/]");

                    try
                    {
                        var list = await accountCommand.ListTenantsAsync();
                        if (list != null && list.Any())
                        {
                            foreach (var item in list)
                            {
                                AnsiConsole.MarkupLineInterpolated($"\t[bold yellow]{item.Name} - {item.Id}[/]");
                            }
                        }
                    }
                    catch (CommandExecutionException ex)
                    {
                        AnsiConsole.MarkupLineInterpolated($"\t[bold red]Unable to get domains for this account[/]");
                    }
                });
        }

        public static async Task PrintDomainsAsync()
        {
            await AnsiConsole.Status()
                .StartAsync("Getting domain for current account...", async ctx =>
                {
                    AnsiConsole.MarkupLine($"[gold1]You have access to the following domains[/]");

                    try
                    {
                        var list = await accountCommand.ListDomainsAsync();
                        if (list != null && list.Any())
                        {
                            foreach (var item in list)
                            {
                                AnsiConsole.MarkupLineInterpolated($"\t[bold yellow]{item.Id}[/]");
                            }
                        }
                    }
                    catch (CommandExecutionException ex)
                    {
                        AnsiConsole.MarkupLineInterpolated($"\t[bold red]Unable to get domains for this account[/]");
                    }
                });
        }

        public static async Task PrintSubscriptionsAsync()
        {
            await AnsiConsole.Status()
                .StartAsync("Getting subscriptions for current account...", async ctx =>
                {
                    var list = await accountCommand.ListSubscriptionsAsync();
                    if (list != null && list.Any())
                    {
                        AnsiConsole.MarkupLine($"[{c1}]You have access to the following subscriptions[/]");

                        var table = new Table();
                        table.Border(TableBorder.None);
                        table.AddColumns("Id", "Property", "Enabled", "Value");

                        foreach (var item in list)
                        {
                            string id = $"[{item.Id}]";
                            switch (item.State.ToLower())
                            {
                                case "enabled":
                                    table.AddRow(string.Empty, $"[bold yellow]{item.DisplayName.Replace('û', '-')}[/]", "Enabled", id.EscapeMarkup());
                                    break;
                                case "disabled":
                                    table.AddRow(string.Empty, $"[bold silver]{item.DisplayName.Replace('û', '-')}[/]", "Disabled", id.EscapeMarkup());
                                    break;
                                default:
                                    break;
                            }
                        }

                        table.Columns[0].Width(7);
                        table.HideHeaders();

                        AnsiConsole.Write(table);
                    }
                });
        }

        public static async Task PrintServicePrincipalsAsync()
        {
            await AnsiConsole.Status()
                .StartAsync("Listing Service Principals...", async ctx =>
                {
                    var list = await sps.ListServicePrincipalsAsync();
                    if (list != null && list.Any())
                    {
                        AnsiConsole.MarkupLine($"[gold1]You have access to the following service principals[/]");
                        foreach (var item in list)
                        {
                            string id = $"[{item.Id}]";
                            AnsiConsole.MarkupLineInterpolated($"[bold yellow]{item.DisplayName}[/] {id}!");
                        }
                    }
                });
        }
    }
}
