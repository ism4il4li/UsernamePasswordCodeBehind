namespace UsernamePasswordCodeBehind;

public partial class UsernamePassword : ContentPage
{
	public UsernamePassword()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(entryName.Text=="Ismail" && entryPassword.Text== "4li")
		{
			DisplayAlert("welcome", "you have successfully logged in", "ok");
		}
		else
		{
            DisplayAlert("Oops!", "wrong, try again", "ok");
        }
    }
}