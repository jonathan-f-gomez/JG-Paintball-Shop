# JG Paintball Shop
This a Paintball store that I am building for Class. :rage4:

[Link to the authors work :suspect:](https://www.apress.com/gp/book/9781484254394)

<details>
  <summary>Table of Contents</summary>
    
  1. [Script](https://github.com/jonathan-f-gomez/JG-Paintball-Shop#script-that-i-used)
  2. [Screenshots Part 1](https://github.com/jonathan-f-gomez/JG-Paintball-Shop#screenshots-of-part-1)
</details>

## Script that I used.
```
    dotnet new globaljson --sdk-version 5.0.103 --output PaintBallSln/JGPaintballShop
    dotnet new web --no-https --output PaintBallSln/JGPaintballShop --framework net5.0
    dotnet new sln -o PaintBallSln

    dotnet sln PaintBallSln add PaintBallSln/JGPaintballShop 

    dotnet new xunit -o PaintBallSln/JGPaintballShop.Tests --framework net5.0
    dotnet sln PaintBallSln add PaintBallSln/JGPaintballShop.Tests 
    dotnet add PaintBallSln/JGPaintballShop.Tests reference PaintBallSln/JGPaintballShop 

    dotnet add PaintBallSln/JGPaintballShop.Tests package Moq --version 4.16.1
```


## Screenshots of Part 1
![Step 1](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/Step1.JPG)
### After Adding CSS
![Step 2](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/Step2.JPG)

