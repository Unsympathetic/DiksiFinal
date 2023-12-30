**Ваннес Лейс Мустафаевич**
==================================
ИП-20-7к
----------------------------------
Магазин Дикси
----------------------------------
![image](https://github.com/Unsympathetic/Diksi/assets/104492314/5cbe87fd-14f9-43ec-8796-a5042201182b)
----------------------------------
```mermaid
erDiagram
  
 
    Pokupatel ||--o{ Nakladnaya : places
    Pokupatel {
        string name
        int Index
        string Address
        int Number
        string Email
    }
  
    Nakladnaya {
        string Name
        string Description
    }
Tovar ||--o{ Nakladnaya : places
    Tovar {
        string Name
        string EdIzmer
 
    }
Postavchik ||--o{ Nakladnaya : places
  Postavchik {
    string Name
    int INN
    int Index
    string Addres
    string Email
   }

```
