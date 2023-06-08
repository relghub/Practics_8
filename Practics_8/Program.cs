namespace Structures
{
    class Program
    {
        struct Child
        {
            public string surname;
            public char sex;
            public string illness;
            public int days;
            public string Output()
            {
                string s = surname + "\t" + Convert.ToString(sex)
                                   + "\t" + Convert.ToString(illness)
                                   + "\t" + Convert.ToString(days);
                return s;
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            List<Child> patients = new List<Child>();
            Child patient;
            List<Child> male_patients = new();
            List<Child> female_patients = new();
            int n = 5;
            string ill;
            int patientsByIllness = 0;
            Console.WriteLine("Введіть дані: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Прізвище: ");
                patient.surname = Console.ReadLine();
                if (patient.surname.Length < "Прізвище".Length)
                {
                    patient.surname += "\t";
                }
                Console.Write("Стать: ");
                patient.sex = Convert.ToChar(Console.ReadLine());
                Console.Write("Хвороба: ");
                patient.illness = Console.ReadLine();
                Console.Write("Скільки днів хворіє: ");
                patient.days = Convert.ToInt32(Console.ReadLine());
                patients.Add(patient);
            }
            Console.WriteLine("Список пацієнтів");
            Console.WriteLine("Прізвище\tСтать\tХвороба\tДнів госпіталізації");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(patients[i].Output());
            }
            for (int i = 0; i < n; i++)
            {
                if (patients[i].sex == 'ч') 
                { 
                    male_patients.Add(patients[i]); 
                }
                else if (patients[i].sex == 'ж') 
                {
                    female_patients.Add(patients[i]); 
                }
            }
            if (male_patients.Count > female_patients.Count)
            {
                Console.WriteLine("Хлопчики хворіють довше.");
            }
            else if (female_patients.Count > male_patients.Count)
            {
                Console.WriteLine("Дівчата хворіють довше.");
            }
            else
            {
                Console.WriteLine("Діти обидвох статей хворіють " +
                                  "однакову кількість днів.");
            }
            Console.Write("Введіть хворобу: ");
            ill = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (patients[i].illness == ill)
                {
                    patientsByIllness += 1;
                }
            }
            Console.WriteLine($"Хворобу {ill} мають " +
                              $"{patientsByIllness} пацієнтів.");
        }
    }
}