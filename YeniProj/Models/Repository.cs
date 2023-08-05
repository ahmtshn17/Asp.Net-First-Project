namespace YeniProj.Models{


    public class Repository{

        static readonly List<Course> _courses = new();
        
        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course()
                {
                    Id=1,
                    Name="PHP Kursu",
                    Description="Açıklama-1",
                    Image="1.jpg",
                    IsActive=false,
                    IsHome=false
                },
                new Course()
                {
                    Id=2,
                    Name="Pyhton Kursu",
                    Description="Açıklama-2",
                    Image="2.jpg",
                    IsActive=true,
                    IsHome=true,
                    Tags= new string[] {"Pyhthon", "Yapay Zeka","Makine Öğrenimi"}
                },
                new Course()
                {
                    Id=3,
                    Name="C# Kursu",
                    Description="Açıklama-3",
                    Image="3.jpg",
                    IsActive=true,
                    IsHome=true,
                     Tags= new string[] {"C#", "Web Geliştirme","Algoritma Öğrenimi"}
                },
                 new Course()
                {
                    Id=4,
                    Name="C# Kursu",
                    Description="Açıklama-3",
                    Image="3.jpg",
                    IsActive=true,
                    IsHome=true
                },
                  new Course()
                {
                    Id=5,
                    Name="C# Kursu",
                    Description="Açıklama-3",
                    Image="3.jpg",
                    IsActive=true,
                    IsHome=true
                }
            };

        }



        public static List<Course> Courses 
        { 

            get
            {

                return _courses;
            }  
    
        }


        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }

    

}


