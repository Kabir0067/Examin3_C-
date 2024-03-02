using System;

namespace Task6
{
   
    Cat cat1 = new Cat("Moshon");
    cat1.Greets();

    Dog dog1 = new Dog("Rembo");
    dog1.Greets();
    Dog anotherDog = new Dog("AnotherDog");
    dog1.Greets(anotherDog);

    BigDog bigDog1 = new BigDog("Titan");
    bigDog1.Greets();
    bigDog1.Greets(anotherDog);
    BigDog anotherBigDog = new BigDog("AnotherBigDog");
    bigDog1.Greets(anotherBigDog);
}