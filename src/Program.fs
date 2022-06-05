open FsharpMyExtension
open FsharpMyExtension.Tree

let buildTree path =
    let rec toTree path =
        let root = System.IO.DirectoryInfo path

        let dirs =
            root.GetDirectories()
            |> Array.map (fun x -> toTree x.FullName)

        let files =
            root.GetFiles()
            |> Array.map (fun file ->
                Node(file.Name, [])
            )

        Node(root.Name,
            Array.append dirs files |> List.ofArray
        )


    toTree path

let visualizeTree path =
    // todo: check it's a folder

    buildTree path
    |> Tree.visualize id

[<EntryPoint>]
let main args =
    let helpMsg =
        [
            "<path-to-directory> for create subdirectories and files tree for this directory"
            "`-h` or `--help`    for call this menu"
        ]
        |> String.concat "\n"
    match args with
    | [|"-h" | "--help"|] ->
        printfn "%s" helpMsg
    | [|path|] ->
        visualizeTree path
        |> printfn "%s"
    | _ ->
        printfn "Unknown these args: %A\n\n%s" args helpMsg
    0
