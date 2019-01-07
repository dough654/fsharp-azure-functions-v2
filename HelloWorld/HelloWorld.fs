namespace AzureFunctionFSharp

open System;
open System.IO;
open System.Threading.Tasks;
open Microsoft.Azure.WebJobs;
open Microsoft.Azure.WebJobs.Extensions.Http;
open Microsoft.AspNetCore.Http;
open Microsoft.AspNetCore.Mvc;
open Microsoft.Extensions.Logging;

module HelloWorld=
    type Person = {
        Name: string
        Greeting: string
    }
    type Error = {
        Message: string
    }
    [<FunctionName("HelloWorld")>]
    let Run([<HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)>] req: HttpRequest, log: ILogger)=
    
        log.LogInformation("F# HTTP trigger function processed a request.")
        
        let name = req.Query.["Name"].ToString()
        let res = req.HttpContext.Response
        match String.length name with
            | 0 -> 
                res.StatusCode <- 400
                ObjectResult({ Message = "No Good, Please provide a Name in the Query string"})
            | _ ->
                res.StatusCode <-200
                ObjectResult({ Name = name; Greeting = "Hello, " + name})




        
