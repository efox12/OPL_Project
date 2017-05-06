﻿module water

let gallonsToCups gallons = gallons * 16.0
let gallonsToLiters gallons = gallons * 3.75
let gallonsToBathtubs gallons = gallons / 110.0 
let gallonsToSwimmingPools gallons = gallons / 30000.0

let cupsToGallons cups = cups / 16.0
let cupsToLiters cups =  gallonsToLiters(cupsToGallons cups)
let cupsToBathtubs cups = gallonsToBathtubs(cupsToGallons cups)
let cupsToSwimingPools cups =  gallonsToSwimmingPools(cupsToGallons cups)

let litersToGallons liters = liters / 3.75
let litersToCups liters = gallonsToCups(litersToGallons liters) 
let litersToBathtubs liters = gallonsToBathtubs(litersToGallons liters)
let litersToSwimmingPools liters =  gallonsToSwimmingPools(litersToGallons liters)

let bathtubsToGallons bathtubs = bathtubs * 110.0
let bathtubsToCups bathtubs = gallonsToCups(bathtubsToGallons bathtubs) 
let bathtubsToLiters bathtubs = gallonsToLiters(bathtubsToGallons bathtubs) 
let bathtubsToSwimmingPools bathtubs =  gallonsToSwimmingPools(bathtubsToGallons bathtubs)

let swimmingPoolsToGallons swimmingPools = swimmingPools * 30000.0
let swimmingPoolssToCups swimmingPools = gallonsToCups(swimmingPoolsToGallons swimmingPools)
let swimmingPoolssToLiters swimmingPools = gallonsToLiters(swimmingPoolsToGallons swimmingPools) 
let swimmingPoolsToBathtubs swimmingPools = gallonsToBathtubs(swimmingPoolsToGallons swimmingPools)

let waterToWater func1 measure1 func2 = 
  func1 measure1 |> func2

