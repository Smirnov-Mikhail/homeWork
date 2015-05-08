open System.Net
open System.Text.RegularExpressions

let downloadPage (url: string) =
    async { 
        try 
            let uri = new System.Uri(url)
            let webClient = new WebClient()
            let! html = webClient.AsyncDownloadString(uri)
            return html
        with
            | ex -> return ex.Message
    }

let downloadWebPages (url: string) =
    Async.RunSynchronously <|
        async {
            let! mainHtml = downloadPage url
            let reg = new Regex(@"href=""http://?(\w|((?!\s|'|"")\W))*""")
            let matches = reg.Matches(mainHtml)
            let references = [|for i in matches -> i.Value.Substring(6, i.Value.Length - 7)|]
            let tasks = [|for ref in references -> downloadPage ref|]
            let! results = Async.Parallel tasks 
            for i in 0..references.Length - 1 do
                printfn "%s --- %d" references.[i] results.[i].Length }

downloadWebPages "http://xn--j1aacto4c.xn--p1ai/"
