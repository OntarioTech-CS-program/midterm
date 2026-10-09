# midterm

Part 2:
This shader not only calculates the reflections of a cubemap on the surroundings, but it also allows you to assign a player color and texture, and unlike the ones shown in class, allows you to assign a metallic and smoothness value. The reflections, metallic, and smoothness are great for replicating the material of a car, and the texture and color are great for this game because they will allow players to customize their car's decals and colors.

Part 3:
This shader adds a time value the UVs of a sandy texture, creating an effect where the sand texture scrolls along a surface. this creates an effect makes it looks like the cars are speeding across the ground.

Part 4:
This effect is similar to the scrolling sand one, but uses multiple sets of UV offsets by different time scales, creating a more varied effect with smoke moving at varying speeds.

part 5:
This shader can change the lighting properties of the car. This was done by creating boolean input values and branch nodes that can turn off each part of the lighting model. This will be useful because when the car hits something and destroys it, the parts inside of that obejct will be exposed, and will have different material properties that reflect light differently, and these can be changed at runtime.
