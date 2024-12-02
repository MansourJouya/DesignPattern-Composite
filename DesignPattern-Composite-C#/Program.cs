using System;
using System.Collections.Generic;

/// <summary>
/// Interface for components in a composite structure.
/// </summary>
public interface IComponent
{
    void Display(int depth);
}

/// <summary>
/// Leaf class representing individual objects in the composition.
/// </summary>
public class Leaf : IComponent
{
    private readonly string _name;

    /// <summary>
    /// Initializes a new instance of the Leaf class.
    /// </summary>
    /// <param name="name">The name of the leaf.</param>
    public Leaf(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Displays the name of the leaf with indentation based on depth.
    /// </summary>
    /// <param name="depth">The depth of the current level in the composition.</param>
    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth * 2) + _name);
    }
}

/// <summary>
/// Composite class that holds children components and implements IComponent.
/// </summary>
public class Composite : IComponent
{
    private readonly List<IComponent> _children = new List<IComponent>();
    private readonly string _name;

    /// <summary>
    /// Initializes a new instance of the Composite class.
    /// </summary>
    /// <param name="name">The name of the composite component.</param>
    public Composite(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Adds a child component to the composite.
    /// </summary>
    /// <param name="component">The component to add.</param>
    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    /// <summary>
    /// Removes a child component from the composite.
    /// </summary>
    /// <param name="component">The component to remove.</param>
    public void Remove(IComponent component)
    {
        _children.Remove(component);
    }

    /// <summary>
    /// Displays the composite structure, including its children.
    /// </summary>
    /// <param name="depth">The depth of the current level in the composition.</param>
    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth * 2) + _name);
        foreach (var child in _children)
        {
            child.Display(depth + 1);
        }
    }
}

/// <summary>
/// Client code to demonstrate the composite pattern.
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create leaf nodes
        IComponent leaf1 = new Leaf("Leaf 1");
        IComponent leaf2 = new Leaf("Leaf 2");
        IComponent leaf3 = new Leaf("Leaf 3");

        // Create composite nodes
        Composite composite1 = new Composite("Composite 1");
        Composite composite2 = new Composite("Composite 2");

        // Build the structure
        composite1.Add(leaf1);
        composite1.Add(leaf2);
        composite2.Add(leaf3);
        composite2.Add(composite1);

        // Display the structure
        Console.WriteLine("Displaying Composite Structure:");
        composite2.Display(1);
    }
}
