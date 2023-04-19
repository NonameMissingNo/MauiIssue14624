namespace Globeng.MAUI.Pages;

public partial class ExamTasks : ContentPage
{
    public ExamTasks()
    {
        InitializeComponent();
        LoadAnswersLayout();
    }

    private Button CreateEndButton()
    {
        Button innerbutt = new()
        {
            HorizontalOptions = LayoutOptions.Fill,
            TextColor = Color.FromRgb(255, 255, 255),
            Text = ("tovább").ToUpper(),
            CornerRadius = 20,
            Margin = new Thickness(15, 10, 15, 30)
        };
        innerbutt.Clicked += End_Clicked;
        return innerbutt;
    }
    private void End_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    private Label CreateLabel(string text, Color color = null)
    {
        Label innerlab = new()
        {
            HorizontalTextAlignment = TextAlignment.Start,
            HorizontalOptions = LayoutOptions.Fill,
            Text = text,
            TextColor = color ?? Color.FromRgb(0, 0, 0)
        };
        return innerlab;
    }
    private StackLayout CreateTRFA()
    {
        Button Selected = null;
        StackLayout inner = new()
        {
            HorizontalOptions = LayoutOptions.Fill,
            Orientation = StackOrientation.Horizontal
        };
        Button check = new()
        {
            //Text = "✔️",
            Text = "✅",
            TextColor = Color.FromArgb("#FFFFFFFF")
        };
        check.HeightRequest = 60;
        check.WidthRequest = 60;
        check.BackgroundColor = Color.FromRgba("#00000000");
        check.BorderWidth = 5;
        check.BorderColor = Color.FromRgba("#FFFFFFFF");
        check.TextColor = Color.FromRgba("#FFFFFFFF");
        check.Clicked += TRFA_Clicked;
        Button cross = new()
        {
            Text = "❌",
            TextColor = Color.FromArgb("#FFFFFFFF")
        };
        cross.HeightRequest = 60;
        cross.WidthRequest = 60;
        cross.BackgroundColor = Color.FromRgba("#00000000");
        cross.BorderWidth = 5;
        cross.BorderColor = Color.FromRgba("#FFFFFFFF");
        cross.TextColor = Color.FromRgba("#FFFFFFFF");
        cross.Clicked += TRFA_Clicked;
        Button didntsay = new()
        {
            Text = ("Nem hangzott el").ToUpper(),
            TextColor = Color.FromArgb("#FFFFFFFF")
        };
        didntsay.HeightRequest = 60;
        didntsay.CornerRadius = 30;
        didntsay.BackgroundColor = Color.FromRgba("#00000000");
        didntsay.BorderWidth = 5;
        didntsay.BorderColor = Color.FromRgba("#FFFFFFFF");
        didntsay.TextColor = Color.FromRgba("#FFFFFFFF");
        didntsay.Clicked += TRFA_Clicked;
        inner.Add(check);
        inner.Add(cross);
        inner.Add(didntsay);
        if (Selected != null)
        {
            Selected.BackgroundColor = Color.FromRgb(80, 80, 80);
        }
        return inner;
    }
    private void TRFA_Clicked(object sender, EventArgs e)
    {
        try
        {
            Button Button = sender as Button;
            Button.BackgroundColor = Color.FromRgb(80, 80, 80);
            switch (Button.Text)
            {
                //case "✔️": {
                case "✅":
                    {
                        Button.BackgroundColor = Color.FromRgb(80, 80, 80);
                        break;
                    }
                case "❌":
                    {
                        Button.BackgroundColor = Color.FromRgb(80, 80, 80);
                        break;
                    }
                case "NEM HANGZOTT EL":
                    {
                        Button.BackgroundColor = Color.FromRgb(80, 80, 80);
                        break;
                    }
            }
            //Selection[answer.Id] = Button;
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
    private void LoadAnswersLayout()
    {
        Dispatcher.Dispatch(() =>
        {
            //List<GraduateTestTask> testTasks = task.GraduateTestTasks.ToList();
            for (int i = 0; i < 10; i++)
            {
                correctview.Add(CreateLabel("This is a label", Color.FromArgb("#FFFFFFFF")));
                correctview.Add(CreateTRFA());
            }
            correctview.Add(CreateEndButton());
        });
    }
}