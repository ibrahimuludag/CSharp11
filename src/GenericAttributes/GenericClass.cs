namespace GenericAttributes;

[Generic<int>()]
public class GenericClass1
{
}

[Generic<string>()]
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