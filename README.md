# **🌟 Group Join LINQ Uygulaması 🌟**

Bu proje, **C#** kullanarak **`GroupJoin` LINQ sorgusuyla** sınıflar ve o sınıfa kayıtlı öğrenciler arasında bir ilişkilendirme yapmayı göstermektedir.

---

## **🎯 Amaç**

- **Sınıflar** (`Classes`) ve **öğrenciler** (`Students`) arasında bir bağlantı kurarak her sınıfa ait öğrencilerin listesini oluşturmak.
- **`GroupJoin`** kullanılarak:
  - Her sınıfın adı (**`ClassName`**) ve o sınıfa ait öğrenciler (**`Student`**) gruplandırılır.
  - Sonuçlar ekrana yazdırılır.

---

## **📂 Proje Yapısı**

### **📝 Veri Modelleri**

#### **`Students` Listesi**
- **Öğrenci Kimliği**: `StudentId`
- **Öğrenci Adı**: `StudentName`
- **Bağlı Olduğu Sınıf Kimliği**: `ClassId`

#### **`Classes` Listesi**
- **Sınıf Kimliği**: `ClassId`
- **Sınıf Adı**: `ClassName`

---

## **🔍 LINQ GroupJoin Açıklaması**

### **🔑 Anahtar Kıyaslama**
- **`student.ClassId`**: Öğrencinin bağlı olduğu sınıfın kimliği.
- **`classes.ClassId`**: Sınıfın kimliği.

### **📊 Sonuç**
- Her sınıf, o sınıfa ait öğrencilerle eşleştirilir.

---

## **📤 Çıktı Formatı**

Her sınıfın adı ve o sınıfa kayıtlı öğrenciler ekrana yazdırılır.

### **Örnek Çıktı:**
```plaintext
Ders Adı: Matematik
Derse kayıtlı olan öğrenciler:
  - Ali
  - Mehmet
----------------------
Ders Adı: Türkçe
Derse kayıtlı olan öğrenciler:
  - Ayşe
  - Ahmet
----------------------
Ders Adı: Kimya
Derse kayıtlı olan öğrenciler:
  - Fatma
----------------------
