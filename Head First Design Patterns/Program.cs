using System;

namespace Head_First_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("Garage");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn =
                new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff =
                new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn =
                new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff =
                new LightOffCommand(kitchenLight);

            CeilingFanOnCommand ceilingFanOn =
                new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff =
                new CeilingFanOffCommand(ceilingFan);
            GarageDoorUpCommand garageDoorUp =
                new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown =
                new GarageDoorDownCommand(garageDoor);
            StereoOnWithCDCommand stereoOnWithCD =
                new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff =
                new StereoOffCommand(stereo);
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl);
            // remoteControl.OnButtonWasPushed(0);
            // remoteControl.OffButtonWasPushed(0);
            // remoteControl.OnButtonWasPushed(1);
            // remoteControl.OffButtonWasPushed(1);
            // remoteControl.OnButtonWasPushed(2);
            // remoteControl.OffButtonWasPushed(2);
            // remoteControl.OnButtonWasPushed(3);
            // remoteControl.OffButtonWasPushed(3);
        }
    }
}
