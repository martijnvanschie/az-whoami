using Azure.Cli.Model;
using Azure.Cli.Model.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Wrap = CliWrap;

namespace Azure.Cli.Commands
{
    public class ExtensionCommands
    {
        /// <summary>
        /// List service principals.
        /// https://learn.microsoft.com/en-us/cli/azure/ad/sp?view=azure-cli-latest#az-ad-sp-list
        /// </summary>
        /// <returns>
        /// For low latency, by default, only the first 100 will be returned unless you provide filter arguments or use "--all".
        /// </returns>
        public static async Task<List<Extension>> ListServicePrincipalsAsync()
        {
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();

            try
            {
                var result = await Wrap.Cli.Wrap("az")
                .WithArguments("extension list")
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

            var myDeserializedClass = JsonSerializer.Deserialize<List<Extension>>(stdOut);
            return myDeserializedClass;
        }
    }
}
