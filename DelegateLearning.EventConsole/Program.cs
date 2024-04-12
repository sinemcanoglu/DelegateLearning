using DelegateLearning.EventConsole;

AlarmSystem alarmSystem = new();
Logger logger = new();

// Event based 
TemperatureSensorEventBased sensor = new();
sensor.TemperatureChanged += alarmSystem.ActivateAlarm;
sensor.TemperatureChanged += logger.LogTemperature;

Console.WriteLine("Enter the current temperature: ");
var currentTemperature = Convert.ToInt32(Console.ReadLine());

sensor.CurrentTemperature = currentTemperature;


// Delegate based 
TemperatureSensorDelegateBased sensorDelegate = new();
sensorDelegate.TemperatureChanged += alarmSystem.ActivateAlarm;
sensorDelegate.TemperatureChanged += logger.LogTemperature;

Console.WriteLine("Enter the current temperature: ");
var currentTemp = Convert.ToInt32(Console.ReadLine());

sensorDelegate.TemperatureChanged.Invoke(sensorDelegate, new TemperatureChangedEventArgs(currentTemp));

