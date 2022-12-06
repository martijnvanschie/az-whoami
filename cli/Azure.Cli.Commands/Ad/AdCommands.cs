using Azure.Cli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Cli.Model.ActiveDirectory;

using Wrap = CliWrap;

namespace Azure.Cli.Commands.Ad
{
    public class AdCommands : AzureCliCommand
    {
        /// <summary>
        /// List service principals.
        /// https://learn.microsoft.com/en-us/cli/azure/ad/sp?view=azure-cli-latest#az-ad-sp-list
        /// </summary>
        /// <returns>
        /// For low latency, by default, only the first 100 will be returned unless you provide filter arguments or use "--all".
        /// </returns>
        public async Task<List<ServicePrincipal>> ListServicePrincipalsAsync()
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            try
            {
                var result = await Wrap.Cli.Wrap("az")
                .WithArguments("ad sp list")
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

            var myDeserializedClass = JsonSerializer.Deserialize<List<ServicePrincipal>>(stdOut);
            return myDeserializedClass;
        }

        /// <summary>
        /// https://learn.microsoft.com/en-us/cli/azure/ad/sp?view=azure-cli-latest#az-ad-sp-show
        /// </summary>
        /// <returns></returns>
        public async Task<ServicePrincipal> GetServicePrincipalAsync(string id)
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            try
            {
                var result = await Wrap.Cli.Wrap("az")
                .WithArguments($"ad sp show --id {id}")
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

            var myDeserializedClass = JsonSerializer.Deserialize<ServicePrincipal>(stdOut);
            return myDeserializedClass;
        }

        /// <summary>
        /// https://learn.microsoft.com/en-us/cli/azure/ad/sp?view=azure-cli-latest#az-ad-sp-show
        /// </summary>
        /// <returns></returns>
        public async Task<AdUser> GetSignedInUserAsync()
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            try
            {
                var result = await Wrap.Cli.Wrap("az")
                .WithArguments("ad signed-in-user show")
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

            var myDeserializedClass = JsonSerializer.Deserialize<AdUser>(stdOut);
            return myDeserializedClass;
        }
    }
}
