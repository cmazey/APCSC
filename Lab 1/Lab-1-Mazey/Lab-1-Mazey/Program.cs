// See https://sehs.io for more information
using Raylib_cs;


Raylib.InitWindow(400, 300, "Hello World");

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing(); // Start Drawing Code
    Raylib.ClearBackground(Color.WHITE);

    Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);
    Raylib.DrawRectangle(300, 200, 40, 20, Color.RED);

    Raylib.EndDrawing();// End Drawing Code
}

Raylib.CloseWindow();