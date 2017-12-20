# PUBG-OFFSETS

A list of auto generated offsets extracted from PUBG SDK to use in an external "tool"

Just reference these in your project and instead of manually updating offsets everytime they change, just overwrite the files with the new one. 

These will be updated as soon as there's a new SDK available.


I've added XML comments so that when in Visual Studio you know to what type of object this offset points to, example:

```
///<summary>USceneComponent *</summary>
public const int RootComponent = 0x0188;
```
