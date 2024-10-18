{-# LANGUAGE OverloadedStrings #-}

-- This function will trigger the "Redundant flip" hint
redundantFlipExample :: (a -> b -> c) -> b -> a -> c
redundantFlipExample f x y = flip f y x
