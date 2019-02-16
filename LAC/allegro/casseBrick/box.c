/* CFPT-EI, Tis-e1b, 04.02.2019 
minimal source for testing allegro installation */

/* 
 package : apt-get install liballegro5-dev
 compilation : 
   export PKG_CONFIG_PATH=/usr/lib/x86_64-linux-gnu/pkgconfig
   gcc -Wall -o hello_allegro hello_allegro.c $(pkg-config --cflags --libs allegro-5.0 allegro_font-5.0 allegro_ttf-5.0)
*/
#include "box.h"
#include "tests.h"

void Box_initializer(Box *this, int pos_x, int pos_y, int width, int height) {
    this->pos_x = pos_x;
    this->pos_y = pos_y;
    this->width = width;
    this->height = height;
}
void Box_clone(Box *this, Box other) {
    other.pos_x = this->pos_x;
    other.pos_y = this->pos_y;
    other.width = this->width;
    other.height = this->height;
}
bool Box_detect_collision(Box *this, Box other) {
    int this_max_x = this->pos_x + this->width;
    int this_max_y = this->pos_y + this->height;
    int other_max_x = other.pos_x + this->width;
    int other_max_y = other.pos_y + this->height;

    if ((this->pos_x <= other.pos_x && this_max_x >= other.pos_x && this->pos_y <= other.pos_y && this_max_y >= other.pos_y) ||
        (this->pos_x <= other.pos_x && this_max_x >= other_max_x && this->pos_y <= other.pos_y && this_max_y >= other_max_y)) {
        return true;
    } else {
        return false;
    }
    
}

#define UNIT_TESTS 
#ifdef UNIT_TESTS 
/* Start the overall test suite */
START_TESTS()

/* A new group of tests, with an identifier */
START_TEST("Box_initializer")
    Box box;
    Box_initializer(&box, 1, 2, 5, 7);
    ASSERT(box.pos_x == 1 );
    ASSERT(box.pos_y == 2 );
    ASSERT(box.width == 5 );
    ASSERT(box.height == 7 );
END_TEST()
START_TEST("Box_clone")
    Box box1;
    Box box2;

    Box_initializer(&box1, 1, 2, 5, 7);
    Box_clone(&box1, box2);

    ASSERT(box2.pos_x == box1.pos_x );
    ASSERT(box2.pos_y == box1.pos_y );
    ASSERT(box2.width == box1.width );
    ASSERT(box2.height == box1.height );
END_TEST()

START_TEST("Box_detect_collision")
    Box box1;
    Box box2;
    Box_initializer(&box1, 1, 1, 5, 5);
    Box_initializer(&box2, 4, 2, 5, 5);
    ASSERT(Box_detect_collision(&box1, box2) == true);
    ASSERT(Box_detect_collision(&box2, box1) == true);
    box2.pos_x = 10;
    ASSERT(Box_detect_collision(&box1, box2) == false);
    ASSERT(Box_detect_collision(&box2, box1) == false);
END_TEST()

/*/ End the overall test suite */
END_TESTS()
#endif