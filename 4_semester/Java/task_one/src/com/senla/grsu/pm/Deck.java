package com.senla.grsu.pm;

import java.util.ArrayList;
import java.util.List;

public class Deck {
    private ArrayList<Container> _containers;

    public Deck() {
        _containers = new ArrayList<>();
    }

    public void AddContainer(Container container) {
        if(ChekFreeSpace()){
            _containers.add(container);
        }
    }

    private boolean ChekFreeSpace() {
        if (_containers.stream().filter(s -> s.get_containerSize() == ContainerSize.Big).count() >= 1||
                _containers.stream().filter(s -> s.get_containerSize() == ContainerSize.Small).count() >= 2) {
            return false;
        }
        return true;
    }
}
