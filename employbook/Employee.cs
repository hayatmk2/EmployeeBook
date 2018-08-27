using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employbook
{
    public class Employee
    {
        //syntax for property prop tap tap
        /// <summary>
        /// this is a coment or summary 
        /// </summary> 
        
        public string Name { get; set; }
        public string Title { get; set; }   
        public int PhoneNumbers { get; set; }
        public static Employee GetEmployee() //static is an instance for all instance to use, oposite of static is instance 
        {
            //create an object 
            var employee = new Employee()

            //employee.Name = " John Doe";
            //employee.Title = "CEO"; or can object initilize like bellow
            {
                Name = "John Doe",
                Title = "CEO",
              
            };
            return employee;
        }
        /// <summary>
        /// wtire employee to file 
        /// </summary>
        /// <param name="employee">the employee object to write</param>
        public static  void WriteEmployee(Employee employee)
        {
            var employeeData = $"{employee.Name},{employee.Title}";
           FileHelper.WriteTextFileAsync("EmoloyeeTextFile.txt", employeeData);
        }
    }
}
