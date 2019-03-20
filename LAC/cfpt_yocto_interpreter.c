/* # $Id: cfpt_yocto_interpreter.c 5900 2015-01-24 21:01:43Z marechal $ */
/* minimal language "yocto" interpreter */
/* Usage : cfpt_yocto_interpreter filename*/
/* Unit tests : compile with -DUNIT_TESTS */
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "tests.h"

#define CODE_SIZE 16384
#define MEMORY_SIZE 16384
#define DISPLAY_BUFFER_SIZE 32768

#define NEXT 'n'
#define PREVIOUS 'p'
#define ADD '+'
#define SUBTRACT '-'
#define BEGIN_LOOP '{'
#define END_LOOP '}'
#define READ 'r'
#define WRITE 'w'

static void err(int code_error_idx, char *s)
{
    fprintf(stderr, "Error detected at byte %d : %s.\n", code_error_idx, s);
    exit(EXIT_FAILURE);
}

static void yocto_parse(char code[], size_t code_length, char display[])
{
    
    unsigned int stack[MEMORY_SIZE];
    int i;
    int ptr_code = 0;
    int ptr_stack = 0;

    unsigned short cpt_display = 0;
    unsigned short cpt_depth = 0;
    unsigned short cpt_depth_destination = 0;

    for(i = 0; i < MEMORY_SIZE; i++){
        stack[i] = 0;
    }

    if (code_length > (size_t)CODE_SIZE)
    {
        err(MEMORY_SIZE, "Code too big");
    }

    while ((size_t)ptr_code < code_length)
    {
        switch (code[ptr_code])
        {
        case NEXT:
            if (++ptr_stack > MEMORY_SIZE)
            {
                err(ptr_code, "Try to access beyond the stack");
            }
            break;

        case PREVIOUS:
            if (ptr_stack == 0)
            {
                err(ptr_code, "Try to access past the stack");
            }
            ptr_stack--;
            break;

        case ADD:
            stack[ptr_stack] = (stack[ptr_stack] + 1);
            break;

        case SUBTRACT:
            stack[ptr_stack] = stack[ptr_stack] - 1;
            break;

        case BEGIN_LOOP:
            cpt_depth++;
            if (stack[ptr_stack] == 0)
            {
                cpt_depth_destination = cpt_depth - 1;
                while (cpt_depth_destination != cpt_depth)
                {
                    ptr_code++;
                    /*Add depth if BEGIN_LOOP and reduce if END_LOOP*/
                    if (code[ptr_code] == BEGIN_LOOP)
                    {
                        cpt_depth++;
                    }
                    if (code[ptr_code] == END_LOOP)
                    {
                        cpt_depth--;
                    }
                }
            }
            break;

        case END_LOOP:
            if (cpt_depth-- == 0)
            {
                err(ptr_code, "Try to close too much loops");
            }
            if (stack[ptr_stack] != 0)
            {
                cpt_depth_destination = cpt_depth + 1;
                while (cpt_depth_destination != cpt_depth)
                {
                    /*changes depth depending on the beginnings and ends of loops*/
                    if (code[--ptr_code] == BEGIN_LOOP)
                    {
                        cpt_depth++;
                    }
                    if (code[ptr_code] == END_LOOP)
                    {
                        cpt_depth--;
                    }
                }
            }
            break;

        case WRITE:
            display[cpt_display] = (char)stack[ptr_stack];
            /*Attribute the endofarray char to next entry*/
            display[++cpt_display] = '\000';
            break;

        /*READ*/
        case READ:
            stack[ptr_stack] = (unsigned int)getchar();
            break;

        /*default*/
        default:
            break;
        }
        ptr_code++;
        
        if (ptr_code > CODE_SIZE)
        {
            err(ptr_code, "Code too big");
        }
    }
    
    if (cpt_depth != 0)
    {
        err(ptr_code, "Not enough end of loop");
    }
    return;
}

#ifdef UNIT_TESTS
START_TESTS()
START_TEST("Hello World!")
{
    /* this bracket is mandatory to permit the variables declaration in the block */
    char code1[] = "++++++++++{n+++++++n++++++++++n+++n+pppp-}n++wn+w"
                   "+++++++ww+++wn++wpp+++++++++++++++wnw+++w------w-"
                   "-------wn+wnw";
    char output_buffer[DISPLAY_BUFFER_SIZE];

    yocto_parse(&code1[0], strlen(code1), &output_buffer[0]);
    ASSERT_EQUALS(strcmp(output_buffer, "Hello World!\n"), 0);
}
END_TEST()

START_TEST("count from 0 to 9")
{
    /* this bracket is mandatory to permit the variables declaration in the block */
    char code1[] = "+++++{-n++++++++++p}n--p+++{-nn++++++++++pp}nn++pp----"
                   "------{+nwnwp+p}";
    char output_buffer[DISPLAY_BUFFER_SIZE];

    yocto_parse(&code1[0], strlen(code1), &output_buffer[0]);
    ASSERT_EQUALS(strcmp(output_buffer, "0 1 2 3 4 5 6 7 8 9 "), 0);
}
END_TEST()

START_TEST("compute 2^6 = 64, ASCII=@")
{
    /* this bracket is mandatory to permit the variables declaration in the block */
    char code1[] = "++++++n+p{n{n++p-}n{p+n-}pp-}nw";
    char output_buffer[DISPLAY_BUFFER_SIZE];

    yocto_parse(&code1[0], strlen(code1), &output_buffer[0]);
    ASSERT_EQUALS(strcmp(output_buffer, "@"), 0);
}
END_TEST()
END_TESTS()
#endif
