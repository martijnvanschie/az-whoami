using System.Text;
using System.Text.Json;
using Azure.Cli.Model.Account;
using Wrap = CliWrap;

namespace Azure.Cli.Commands
{
    public class AccountCommands : AzureCliCommand
    {
        public async Task<List<Account>> ListAccountsAsync()
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            var result = await Wrap.Cli.Wrap("az")
                .WithArguments("account list")
                .WithStandardOutputPipe(Wrap.PipeTarget.ToStringBuilder(stdOutBuffer))
                .WithStandardErrorPipe(Wrap.PipeTarget.ToStringBuilder(stdErrBuffer))
                .ExecuteAsync();

            var stdOut = stdOutBuffer.ToString();
            var stdErr = stdErrBuffer.ToString();

            var myDeserializedClass = JsonSerializer.Deserialize<List<Account>>(stdOut);
            return myDeserializedClass;
        }

        public async Task<Account> ShowAccountAsync()
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            var result = await Wrap.Cli.Wrap("az")
                .WithArguments("account show")
                .WithStandardOutputPipe(Wrap.PipeTarget.ToStringBuilder(stdOutBuffer))
                .WithStandardErrorPipe(Wrap.PipeTarget.ToStringBuilder(stdErrBuffer))
                .ExecuteAsync();


            var stdOut = stdOutBuffer.ToString();
            var stdErr = stdErrBuffer.ToString();

            var myDeserializedClass = JsonSerializer.Deserialize<Account>(stdOut);
            return myDeserializedClass;
        }

        public async Task<List<Tenant>> ListTenantsAsync()
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            var result = await Wrap.Cli.Wrap("az")
                .WithArguments("rest --method GET --uri https://management.azure.com/tenants?api-version=2020-01-01")
                .WithStandardOutputPipe(Wrap.PipeTarget.ToStringBuilder(stdOutBuffer))
                .WithStandardErrorPipe(Wrap.PipeTarget.ToStringBuilder(stdErrBuffer))
                .WithValidation(Wrap.CommandResultValidation.None)
                .ExecuteAsync();


            var stdOut = stdOutBuffer.ToString();
            var stdErr = stdErrBuffer.ToString();

            var myDeserializedClass = JsonSerializer.Deserialize<TenantList>(stdOut);
            return myDeserializedClass.Tenants;
        }

        public async Task<string> GetActiveTenantIdAsync()
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            var result = await Wrap.Cli.Wrap("az")
                .WithArguments("account show --query tenantId")
                .WithStandardOutputPipe(Wrap.PipeTarget.ToStringBuilder(stdOutBuffer))
                .WithStandardErrorPipe(Wrap.PipeTarget.ToStringBuilder(stdErrBuffer))
                .ExecuteAsync();

            var stdOut = stdOutBuffer.ToString();
            var stdErr = stdErrBuffer.ToString();
            return stdOut.Replace("\"", string.Empty).Trim();
        }

        public async Task<Subscription> ShowSubscriptionAsync(string id)
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            try
            {
                var result = await Wrap.Cli.Wrap("az")
                .WithArguments($"account subscription show --id {id}")
                .WithStandardOutputPipe(Wrap.PipeTarget.ToStringBuilder(stdOutBuffer))
                .WithStandardErrorPipe(Wrap.PipeTarget.ToStringBuilder(stdErrBuffer))
                .ExecuteAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            var stdOut = stdOutBuffer.ToString();
            var stdErr = stdErrBuffer.ToString();

            var myDeserializedClass = JsonSerializer.Deserialize<Subscription>(stdOut);
            return myDeserializedClass;
        }

        public async Task<List<Subscription>> ListSubscriptionsAsync()
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            var result = await Wrap.Cli.Wrap("az")
                .WithArguments("account subscription list")
                .WithStandardOutputPipe(Wrap.PipeTarget.ToStringBuilder(stdOutBuffer))
                .WithStandardErrorPipe(Wrap.PipeTarget.ToStringBuilder(stdErrBuffer))
                .ExecuteAsync();

            var stdOut = stdOutBuffer.ToString();
            var stdErr = stdErrBuffer.ToString();

            var myDeserializedClass = JsonSerializer.Deserialize<List<Subscription>>(stdOut);
            return myDeserializedClass;
        }

        public async Task<List<Domain>> ListDomainsAsync()
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            var result = await Wrap.Cli.Wrap("az")
                .WithArguments("rest --method get --url https://graph.microsoft.com/v1.0/domains")
                .WithStandardOutputPipe(Wrap.PipeTarget.ToStringBuilder(stdOutBuffer))
                .WithStandardErrorPipe(Wrap.PipeTarget.ToStringBuilder(stdErrBuffer))
                .ExecuteAsync();

            var stdOut = stdOutBuffer.ToString();
            var stdErr = stdErrBuffer.ToString();

            var myDeserializedClass = JsonSerializer.Deserialize<DomainList>(stdOut);
            return myDeserializedClass.Domains;
        }
    }
}
