﻿


public class Shirts : AllCollection
{
    public Shirts(int amount) : base(amount)
    {
    }

    protected override int Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void SelectedItems(string catagory1, string category2)
    {
        throw new NotImplementedException();
    }
}