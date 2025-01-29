
using Group_Join_Pratic;

// Students ve Classes listeleri tanımlanıyor

List<Students> students = new List<Students>
{
    new Students { StudentId=1, StudentName="Ali", ClassId=1},
    new Students { StudentId=2, StudentName="Ayşe", ClassId=2},
    new Students { StudentId=3, StudentName="Mehmet", ClassId=1},
    new Students { StudentId=4, StudentName="Fatma", ClassId=3},
    new Students { StudentId=5, StudentName="Ahmet", ClassId=2}

};

List<Classes> classes = new List<Classes>
{
    new Classes{ ClassId=1, ClassName="Matematik"},
    new Classes{ ClassId=2, ClassName="Türkçe"},
    new Classes{ ClassId=3, ClassName="Kimya"},
};

// GroupJoin ile sınıflar ve o sınıfa ait öğrenciler birleştiriliyor
var StudentAndClass = classes.GroupJoin(
                                         students,
                                         student => student.ClassId, // Öğrenciler için anahtar
                                         classes => classes.ClassId,// Sınıflar için anahtar
                                         (class2, studentGroup) => new // Her sınıf için sonuç nesnesi oluşturuluyor
                                         {
                                             ClassName = class2.ClassName,
                                             Student = studentGroup,
                                         }

                                         );

// Sonuçlar ekrana yazdırılıyor

foreach ( var s in StudentAndClass)
{
    Console.WriteLine("Ders Adı: " +s.ClassName);     // Önce sınıfın adını yazdırıyoruz
    Console.WriteLine("Derse kayıtlı olan öğrenciler : " );

    foreach ( var item in s.Student) // Eğer sınıfın içinde öğrenciler varsa, bu öğrencileri tek tek döngüyle geziyoruz
    {
        Console.WriteLine(item.StudentName);
        
    }
    Console.WriteLine("----------------------");
}