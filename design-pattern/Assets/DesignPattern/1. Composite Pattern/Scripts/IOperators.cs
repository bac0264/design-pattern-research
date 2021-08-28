using System;

public interface IOperators
{
    int ID { set; get; }
    void SetPointerClick(Action<IOperators> pointerClick);

    void OnPointerClick(IOperators iOperator);
}
