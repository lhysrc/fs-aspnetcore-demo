open System
open System.Collections.Generic
open System.IO
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open WebApplicationDemo


[<EntryPoint>]
let main argv =    

    let host = WebHostBuilder()
                    .UseKestrel()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build()

    host.Run()
    0
