namespace GenericAttributes;

public class GenericAttribute<T> : Attribute {
    public T Name { get; private set; }

	public GenericAttribute(T name)
	{
		Name = name;
	}
}
