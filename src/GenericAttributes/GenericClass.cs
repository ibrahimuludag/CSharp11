namespace GenericAttributes;

[Generic<int>(10)]
public class GenericClass1
{
}

[Generic<string>("Hello World")]
public class GenericClass2
{
}


// Below will not compile
/*
[Generic<T>()]
public class GenericClass3<T>
{
}
*/