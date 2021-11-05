# PrimSharp

A C# library for Constructive Solid Geometry  

Objects are rendered to OpenSCAD code.  
You can paste the rendered code into OpenSCAD and use it to generate an STL file.  

## Notes

Dimensions use Width, Breadth, and Height.
I went with "Breadth" to avoid conflicts with the word "Length."

## Example

Running this: 

``` csharp
new Cube()
    .RotateZ(45)
    .Render();
```

Gives you this: 

``` openscad
rotate([0, 0, 45])
cube([1, 1, 1], center=true);
```

## Primitives

Cube - a rectangular solid

``` csharp
new Cube(width: 3, breadth: 5, height: 2);
```

Cylinder - you know what a cylinder is.

``` csharp
new Cylinder(radius: 2, height: 5);
```




