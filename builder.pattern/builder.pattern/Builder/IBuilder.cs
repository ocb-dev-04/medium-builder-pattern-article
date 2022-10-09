namespace builder.pattern.Builder;

public interface IBuilder<out T>
{
    T Build();
}
