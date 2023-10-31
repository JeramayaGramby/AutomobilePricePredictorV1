using MLTrained_AutomobilePricePredictor;

namespace modelExecution
{ 

    public class ModelConsumption
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the model year of the vehicle:");
                Single year = Convert.ToSingle(Console.ReadLine());
                Console.ReadKey();
                
                Console.WriteLine("Enter the mileage of the vehicle:");
                Single mileage = Convert.ToSingle(Console.ReadLine());
                Console.ReadKey();
                
                Console.WriteLine("Enter the vehicle manufacturer");
                string make = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
                
                Console.WriteLine("Enter the vehicle model:");
                string model = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
                
                Console.WriteLine("Enter the city where the vehicle is located:");
                string city = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
                
                Console.WriteLine("Enter the state of where the vehicle is located (Example: TX, PA):");
                string state = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
               


                MLModel2.ModelInput inputData = new MLModel2.ModelInput()
                {
                    Year = year,
                    Mileage = mileage,
                    City = city,
                    State = state,
                    Make = make,
                    Model = model,
                };

                var predictionResult = MLModel2.Predict(inputData);
                
                Console.WriteLine("The estimated market value for a $"{year}" $"{make}" $"{model}" with " +
                    "$"{mileage}" miles in the $"{city}" area is $$"{predictionResult}");

            }

            // The two most likely exceptions to be thrown are NullReferenceException and ArgumentException. 

            catch (NullReferenceException e)
            {
                Console.WriteLine("Something went wrong. Please restart the program.");
                Console.WriteLine(e);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Something went wrong. Please restart the program.");
                Console.WriteLine(e);
            }
            
        }
    }
        
}
    
