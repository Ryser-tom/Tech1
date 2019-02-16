#include <allegro5/allegro.h>
#include <allegro5/allegro_font.h>
#include <allegro5/allegro_ttf.h>

typedef struct Box_s
{
    int pos_x;
    int pos_y;
    int width;
    int height;
}Box;
void Box_initializer(Box *this, int pos_x, int pos_y, int width, int height);
void Box_clone(Box *this, Box other);
bool Box_detect_collision(Box *this, Box other);
