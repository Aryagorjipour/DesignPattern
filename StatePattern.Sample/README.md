State Pattern Implementation in C#
=====================================

The State pattern is a behavioral design pattern that allows an object to change its behavior when its internal state changes. This pattern is useful when an object's behavior is dependent on its state, and it must change its behavior at runtime.

In this implementation, we've used the State pattern to create a traffic light system that can be in three states: Red, Yellow, and Green. Each state has its own behavior, and the system can change its state dynamically.

Benefits:

-    The State pattern allows the TrafficLight class to change its behavior at runtime without modifying its code.
-    It encapsulates the behavior of each state, making it easier to add or remove states without affecting the rest of the system.
-    It provides a clear separation of concerns between the TrafficLight class and the state classes.

Drawbacks:

-    The State pattern can add complexity to the system, especially if there are many states.
-    It can lead to a proliferation of state classes, making it harder to maintain the system.

Implementation Steps:

-    Define the state interface (ITrafficLightState) that declares the behavior of each state.
-    Create concrete state classes (RedState, YellowState, GreenState) that implement the state interface.
-    Create the context class (TrafficLight) that holds a reference to the current state.
-    Implement the behavior of each state in the corresponding state class.
-    Implement the ChangeState method in the context class to change the current state.
-    Use the State pattern in the client code to change the behavior of the TrafficLight class.

Real-Life Scenarios:

-    A vending machine that can be in different states (e.g., idle, selecting product, dispensing product).
-    A document editor that can be in different states (e.g., editing, reviewing, printing).
-    A network connection that can be in different states (e.g., connected, disconnected, connecting).


**UML Diagrams:**

Here are the UML diagrams for the State pattern implementation using Mermaid:
```mermaid
classDiagram
    class TrafficLight {
        -ITrafficLightState _state
        +ChangeState(ITrafficLightState)
        +Handle()
    }

    class ITrafficLightState {
        <<interface>>
        +Handle()
    }

    class RedState {
        -ITrafficLightState
        +Handle()
    }

    class YellowState {
        -ITrafficLightState
        +Handle()
    }

    class GreenState {
        -ITrafficLightState
        +Handle()
    }

    TrafficLight --> ITrafficLightState
    ITrafficLightState <|-- RedState
    ITrafficLightState <|-- YellowState
    ITrafficLightState <|-- GreenState