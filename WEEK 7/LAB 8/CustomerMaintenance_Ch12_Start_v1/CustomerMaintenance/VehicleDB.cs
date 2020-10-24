using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public static class VehicleDB
	{
		private const string dir = @"C:\C# 2015\Files\";
		private const string path = dir + "Customers.txt";

		public static void SaveVehicle(List<Vehicle> vehicles)
		{
			// create the output stream for a text file that exists
			StreamWriter textOut = 
				new StreamWriter(
				new FileStream(path, FileMode.Create, FileAccess.Write));

			// write each customer
			foreach (Vehicle vehicle in vehicles)
			{
				textOut.Write(vehicle.VinNumber + "|");
				textOut.Write(vehicle.Description + "|");
				textOut.Write(vehicle.PurchasePrice + "|");
				textOut.Write(vehicle.NumberOfDoors + "|");
				textOut.WriteLine(vehicle.BedType);
			}

			// write the end of the document
			textOut.Close();
		}

        public static List<Vehicle> GetVehicle()
		{
			// if the directory doesn't exist, create it
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);

			// create the object for the input stream for a text file
			StreamReader textIn = 
				new StreamReader(
					new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

			// create the array list for customers
            List<Vehicle> vehicles = new List<Vehicle>();

			// read the data from the file and store it in the ArrayList
			while (textIn.Peek() != -1)
			{
				string row = textIn.ReadLine();
				string[] columns = row.Split('|');
				Vehicle vehicle = new Vehicle();
				vehicle.VinNumber = columns[0];
				vehicle.Description = columns[1];
				vehicle.PurchasePrice = columns[2];
				//vehicle.NumberOfDoors = columns[3];
				//vehicle.BedType = columns[4];
				vehicles.Add(vehicle);
			}

			textIn.Close();

			return vehicles;
		}
	}
}
