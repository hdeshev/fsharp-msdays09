#light

open System.Windows.Forms

type IDialog =
    abstract Show: unit -> unit

type ButtonForm =
    inherit Form
            
    member this.AddButton() =
        let button = new Button()
        button.Text <- "Click"
        button.Click.Add (fun e -> MessageBox.Show("click!") |> ignore )
        button.Dock <- DockStyle.Fill
        this.Controls.Add(button)
    
    new() as this = {}  then
        this.AddButton()
        this.Text <- "Hello, F#"
         
    interface IDialog with
        member this.Show() =
            this.ShowDialog() |> ignore
    
        
let f = new ButtonForm() :> IDialog
f.Show()