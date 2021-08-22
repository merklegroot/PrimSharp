# PrimSharp

A C# library for Constructive Solid Geometry  

Objects are rendered to OpenSCAD code.  
You can paste the rendered code into OpenSCAD and use it to generate an STL file.  

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

