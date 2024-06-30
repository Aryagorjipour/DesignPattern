Observer Pattern Implementation in C#
=====================================

This implementation demonstrates the Observer pattern, a behavioral design pattern that allows an object to notify other objects about changes to its state.

**What is the Observer Pattern?**

The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. This pattern is useful when there is a one-to-many relationship between objects, and the state of one object affects the behavior of other objects.

**Components of the Observer Pattern**

* **Subject** (WeatherStation): The object being observed, which maintains a list of observers and notifies them when its state changes.
* **Observer** (DisplayBoard, ForecastSystem): The objects that observe the subject and react to changes in its state.
* **register()**: Method to add an observer to the subject's list of observers.
* **unregister()**: Method to remove an observer from the subject's list of observers.
* **notify()**: Method to notify all observers of a change in the subject's state.

**Implementation Details**

This implementation provides a `WeatherStation` class that acts as the subject, and two observer classes, `DisplayBoard` and `ForecastSystem`, that implement the `IObserver` interface. The `WeatherStation` class maintains a list of observers and provides methods to register and unregister observers. When the weather condition changes, it notifies all registered observers by calling their `Update` method.

**UML Diagrams**

Here are the UML diagrams for the implementation using the Mermaid framework:
```mermaid
classDiagram
    class WeatherStation {
        -_observers: List<IObserver>
        -_weatherCondition: string
        +registerObserver(IObserver)
        +unregisterObserver(IObserver)
        +notifyObservers()
        +setWeatherCondition(string)
    }

    class IObserver {
        <<interface>>
        +update(string)
    }

    class DisplayBoard {
        -_weatherCondition: string
        +update(string)
    }

    class ForecastSystem {
        -_weatherCondition: string
        +update(string)
    }

    WeatherStation --> IObserver : observes
    WeatherStation --> DisplayBoard : observes
    WeatherStation --> ForecastSystem : observes
    IObserver <|-- DisplayBoard
    IObserver <|-- ForecastSystem