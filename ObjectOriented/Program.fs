#light

open System.Windows.Forms

type IDialog =
    abstract Show : unit -> unit
    
type ButtonForm =
    inherit Form
    
    new() as this = {} then
        this.AddButton()
        this.Text <- "Hello, F#"
        
    member this.AddButton() =
        let button = new Button()
        button.Text <- "Click me"
        button.Click.Add (fun args -> MessageBox.Show("click!") |> ignore)
        button.Dock <- DockStyle.Fill
        this.Controls.Add(button)
        
    interface IDialog with
        member this.Show() =
            this.ShowDialog() |> ignore
            
            
let f = new ButtonForm() :> IDialog
f.Show()    