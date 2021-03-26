# JG Paintball Shop
This a sports store that I am building for Class. :rage4:

[Link to the authors work :suspect:](https://www.apress.com/gp/book/9781484254394)


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


## Screenshot of Step 1
![Step 1](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/Step1.JPG)

## Screenshot of Step 2
![Step 1](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/Step2.JPG)