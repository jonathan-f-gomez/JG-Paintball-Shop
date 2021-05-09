# JG Paintball
This a Paintball store that I am building for Class. :rage4:

[Link to the authors work :suspect:](https://www.apress.com/gp/book/9781484254394)


### Table of Contents
    
  1. [Script](https://github.com/jonathan-f-gomez/JG-Paintball-Shop#script-that-i-used)
  2. [Screenshots Chapter 7](https://github.com/jonathan-f-gomez/JG-Paintball-Shop#screenshots-of-chapter-7)
  3. [Screenshots Chapter 8](https://github.com/jonathan-f-gomez/JG-Paintball-Shop#screenshots-of-chapter-8)
  4. [Screenshots Chapter 9](https://github.com/jonathan-f-gomez/JG-Paintball-Shop#screenshots-of-chapter-9)
  5. [Screenshots Chapter 10](https://github.com/jonathan-f-gomez/JG-Paintball-Shop#screenshots-of-chapter-10)


## Script that I used.

<details>
  <summary>Collapse me..</summary>

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
</details>

## Screenshots of Chapter 7

<details>
  <summary>Collapse me..</summary>

![Step 1](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/Step1.JPG)
#### After Adding CSS
![Step 2](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/Step2.JPG)

</details>

## Screenshots of Chapter 8

<details>
  <summary>Collapse me..</summary>

#### Navagation bar added. Allows user to filter by Category
![NavBarMenu](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/8-5-SG.JPG)

#### Shopping Cart added.
![NavBarMenu](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/8-10-SG.JPG)

#### Cart Preview.
![NavBarMenu](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/8-11-SG.JPG)

[Look at test results :rage3:](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/Tests-SG.JPG)

</details>

## Screenshots of Chapter 9

<details>
  <summary>Collapse me..</summary>

#### Added the ability for users to remove items from thier shopping cart.
![removeItem](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/9-1-SG.JPG)

#### Widget added to the top right corner that shows users how much thier spening and how many items are in thier cart.
![cartWidget](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/9-2-SG.JPG)

#### Checkout validation to ensure users enter the proper information.
![removeItem](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/9-5-SG.JPG)

#### Checkout screen to show users what order number they are.
![removeItem](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/9-6-SG.JPG)

</details>


## Screenshots of Chapter 10

<details>
  <summary>Collapse me..</summary>

#### Added Admin page that allows administrators to view Products and Orders
![adminPage](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/10-1-SG.JPG)

#### Order Page shows shipped and unshipped orders.
![ordersPage](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/10-3-SG.JPG)

#### Pruducts page lists the all the products.
![removeItem](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/10-5-SG.JPG)

#### Actions you can preform on the prducts.
![removeItem](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/10-9-SG.JPG)

#### Edit product information.
![removeItem](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/10-6-SG.JPG)

</details>

## Screenshots of Chapter 11

<details>
  <summary>Collapse me..</summary>

#### Added Identity to admin page so only admin accounts can reach
![ID](https://github.com/jonathan-f-gomez/JG-Paintball-Shop/blob/master/Screenshots/Final.JPG)

</details>


