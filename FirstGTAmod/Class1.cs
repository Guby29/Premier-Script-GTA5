using System;
using System.Drawing;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.UI;

public class YouTubeTutorial : Script // Change "YouTubeTutorial" to the name of your program.
{
    public YouTubeTutorial() // Change "YouTubeTutorial" to the name of your program.
    {
        Tick += OnTick;
        KeyUp += OnKeyUp;
        KeyDown += OnKeyDown;
    }

    private void OnTick(object sender, EventArgs e) // Code is ran every new frame in-game
    {

    }

    private void OnKeyDown(object sender, KeyEventArgs e) // Code is ran only when a certain key is pressed down
    {
        if(e.KeyCode == Keys.F10)
        {
            // If 'F10' is pressed, execute the following code bellow
            Vehicle vehicle01 = World.CreateVehicle(VehicleHash.Police4, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 3.0f, Game.Player.Character.Heading + 90);

            vehicle01.Mods.CustomPrimaryColor = Color.Black;
            vehicle01.Mods.LicensePlate = "010101";

            Notification.Show("~g~Votre véhicule à Spawn !");
        }

        if (e.KeyCode == Keys.F11)
        {
            // Get the player's current vehicle
            Vehicle playerVehicle = Game.Player.Character.CurrentVehicle;

            // Check if the player is in the vehicle
            if (playerVehicle !=  null)
            {
                playerVehicle.Repair();
                Notification.Show("~g~Votre véhicule à été réparé");
            }
            else
            {
                Notification.Show("~r~ERROR : ~y~Vous n'êtes pas dans un véhicule");
            }
        }
        if (e.KeyCode == Keys.M)
        {
            Ped ped01 = World.CreatePed(PedHash.Abigail, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 3.0f, Game.Player.Character.Heading + 90);
            Notification.Show("~g~Le Personnage à Spawn");
        }
    }

    private void OnKeyUp(object sender, KeyEventArgs e) // Code is ran only when a certain key is released
    {

    }
}