package com.senla.grsu.pm;

public class Container
{
    private float _litersOfWater;
    private ContainerSize _containerSize;

    public Container(ContainerSize containerSize)
    {
        _containerSize = containerSize;
        if(containerSize == ContainerSize.Big)
        {
            _litersOfWater = 1000;
        }
        else
        {
            _litersOfWater = 450;
        }
    }

    public ContainerSize get_containerSize() {
        return _containerSize;
    }
}
