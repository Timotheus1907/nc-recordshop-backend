using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nc_recordshop_backend.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TrackList = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "Description", "Genre", "Name", "Quantity", "ReleaseDate", "TrackList" },
                values: new object[,]
                {
                    { 1, "Pink Floyd", "The eighth album by Pink Floyd, it's a concept album exploring themes of conflict, greed, and time.", "Progressive Rock", "The Dark Side of the Moon", 3, new DateOnly(1973, 3, 1), "[\"Speak to Me\",\"Breathe (In the Air)\",\"On the Run\",\"Time\",\"The Great Gig in the Sky\",\"Money\",\"Us and Them\",\"Any Colour You Like\",\"Brain Damage\",\"Eclipse\"]" },
                    { 2, "Michael Jackson", "One of the best-selling albums of all time and Michael Jackson's seventh studio album.", "Pop, R&B, Funk", "Bad", 0, new DateOnly(1987, 8, 31), "[\"Bad\",\"The Way You Make Me Feel\",\"Speed Demon\",\"Liberian Girl\",\"Just Good Friends\",\"Another Part of Me\",\"Man in the Mirror\",\"I Just Can\\u0027t Stop Loving You\",\"Dirty Diana\",\"Smooth Criminal\",\"Leave Me Alone\"]" },
                    { 3, "Adele", "Named after Adele's age during its production, this is her second studio album.", "Pop, Soul", "21", 17, new DateOnly(2011, 1, 24), "[\"Rolling in the Deep\",\"Rumour Has It\",\"Turning Tables\",\"Don\\u0027t You Remember\",\"Set Fire to the Rain\",\"He Won\\u0027t Go\",\"Take It All\",\"I\\u0027ll Be Waiting\",\"One and Only\",\"Lovesong\",\"Someone Like You\"]" },
                    { 4, "Michael Jackson", "The best-selling album of all time by Michael Jackson.", "Pop, Post-Disco, R&B, Rock", "Thriller", 10, new DateOnly(1982, 11, 29), "[\"Wanna Be Startin\\u0027 Somethin\\u0027\",\"Baby Be Mine\",\"The Girl Is Mine\",\"Thriller\",\"Beat It\",\"Billie Jean\",\"Human Nature\",\"P.Y.T. (Pretty Young Thing)\",\"The Lady in My Life\"]" },
                    { 5, "AC/DC", "The seventh studio album by Australian rock band AC/DC.", "Hard Rock", "Back in Black", 10, new DateOnly(1980, 7, 25), "[\"Hells Bells\",\"Shoot to Thrill\",\"What Do You Do for Money Honey\",\"Given the Dog a Bone\",\"Let Me Put My Love Into You\",\"Back in Black\",\"You Shook Me All Night Long\",\"Have a Drink on Me\",\"Shake a Leg\",\"Rock and Roll Ain\\u0027t Noise Pollution\"]" },
                    { 6, "Whitney Houston", "Soundtrack to the 1992 film, primarily featuring Whitney Houston.", "R&B, Pop", "The Bodyguard", 10, new DateOnly(1992, 11, 17), "[\"I Will Always Love You\",\"I Have Nothing\",\"I\\u0027m Every Woman\",\"Run to You\",\"Queen of the Night\",\"Jesus Loves Me\",\"Even If My Heart Would Break\",\"Someday (I\\u0027m Coming Back)\",\"It\\u0027s Gonna Be a Lovely Day\",\"(What\\u0027s So Funny \\u0027Bout) Peace, Love, and Understanding\",\"Waiting for You\",\"Trust in Me\",\"Theme from The Bodyguard\"]" },
                    { 7, "Fleetwood Mac", "The eleventh studio album by British-American rock band Fleetwood Mac.", "Soft Rock", "Rumours", 10, new DateOnly(1977, 2, 4), "[\"Second Hand News\",\"Dreams\",\"Never Going Back Again\",\"Don\\u0027t Stop\",\"Go Your Own Way\",\"Songbird\",\"The Chain\",\"You Make Loving Fun\",\"I Don\\u0027t Want to Know\",\"Oh Daddy\",\"Gold Dust Woman\"]" },
                    { 8, "Bee Gees", "The soundtrack album from the 1977 film.", "Disco", "Saturday Night Fever", 10, new DateOnly(1977, 11, 15), "[\"Stayin\\u0027 Alive\",\"How Deep Is Your Love\",\"Night Fever\",\"More Than a Woman\",\"If I Can\\u0027t Have You\",\"A Fifth of Beethoven\",\"More Than a Woman (Tavares)\",\"Manhattan Skyline\",\"Calypso Breakdown\",\"Night on Disco Mountain\",\"Open Sesame\",\"Jive Talkin\\u0027\",\"You Should Be Dancing\",\"Boogie Shoes\",\"Salsation\",\"K-Jee\",\"Disco Inferno\"]" },
                    { 9, "Shania Twain", "The third studio album by Canadian singer Shania Twain.", "Country Pop", "Come On Over", 10, new DateOnly(1997, 11, 4), "[\"Man! I Feel Like a Woman!\",\"I\\u0027m Holdin\\u0027 On to Love (To Save My Life)\",\"Love Gets Me Every Time\",\"Don\\u0027t Be Stupid (You Know I Love You)\",\"From This Moment On\",\"Come On Over\",\"When\",\"Whatever You Do! Don\\u0027t!\",\"If You Wanna Touch Her, Ask!\",\"You\\u0027re Still the One\",\"Honey, I\\u0027m Home\",\"That Don\\u0027t Impress Me Much\",\"Black Eyes, Blue Tears\",\"I Won\\u0027t Leave You Lonely\",\"Rock This Country!\",\"You\\u0027ve Got a Way\"]" },
                    { 10, "Meat Loaf", "The 1977 debut album by American rock singer Meat Loaf.", "Hard Rock, Progressive Rock", "Bat Out of Hell", 10, new DateOnly(1977, 10, 21), "[\"Bat Out of Hell\",\"You Took the Words Right Out of My Mouth (Hot Summer Night)\",\"Heaven Can Wait\",\"All Revved Up with No Place to Go\",\"Two Out of Three Ain\\u0027t Bad\",\"Paradise by the Dashboard Light\",\"For Crying Out Loud\"]" },
                    { 11, "Eagles", "The fifth studio album by American rock band Eagles.", "Rock", "Hotel California", 10, new DateOnly(1976, 12, 8), "[\"Hotel California\",\"New Kid in Town\",\"Life in the Fast Lane\",\"Wasted Time\",\"Wasted Time (Reprise)\",\"Victim of Love\",\"Pretty Maids All in a Row\",\"Try and Love Again\",\"The Last Resort\"]" },
                    { 12, "The Beatles", "The eighth studio album by the English rock band the Beatles.", "Psychedelic Rock", "Sgt. Pepper's Lonely Hearts Club Band", 10, new DateOnly(1967, 5, 26), "[\"Sgt. Pepper\\u0027s Lonely Hearts Club Band\",\"With a Little Help from My Friends\",\"Lucy in the Sky with Diamonds\",\"Getting Better\",\"Fixing a Hole\",\"She\\u0027s Leaving Home\",\"Being for the Benefit of Mr. Kite!\",\"Within You Without You\",\"When I\\u0027m Sixty-Four\",\"Lovely Rita\",\"Good Morning Good Morning\",\"Sgt. Pepper\\u0027s Lonely Hearts Club Band (Reprise)\",\"A Day in the Life\"]" },
                    { 13, "Led Zeppelin", "The untitled fourth studio album by the English rock band Led Zeppelin.", "Hard Rock, Heavy Metal", "Led Zeppelin IV", 10, new DateOnly(1971, 11, 8), "[\"Black Dog\",\"Rock and Roll\",\"The Battle of Evermore\",\"Stairway to Heaven\",\"Misty Mountain Hop\",\"Four Sticks\",\"Going to California\",\"When the Levee Breaks\"]" },
                    { 14, "Bruce Springsteen", "The seventh studio album by American rock singer-songwriter Bruce Springsteen.", "Heartland Rock", "Born in the U.S.A.", 10, new DateOnly(1984, 6, 4), "[\"Born in the U.S.A.\",\"Cover Me\",\"Darlington County\",\"Working on the Highway\",\"Downbound Train\",\"I\\u0027m on Fire\",\"No Surrender\",\"Bobby Jean\",\"I\\u0027m Goin\\u0027 Down\",\"Glory Days\",\"Dancing in the Dark\",\"My Hometown\"]" },
                    { 15, "Alanis Morissette", "The third studio album by Canadian singer Alanis Morissette.", "Alternative Rock", "Jagged Little Pill", 10, new DateOnly(1995, 6, 13), "[\"All I Really Want\",\"You Oughta Know\",\"Perfect\",\"Hand in My Pocket\",\"Right Through You\",\"Forgiven\",\"You Learn\",\"Head over Feet\",\"Mary Jane\",\"Ironic\",\"Not the Doctor\",\"Wake Up\"]" },
                    { 16, "The Beatles", "A compilation album by the English rock band the Beatles.", "Rock", "1", 10, new DateOnly(2000, 11, 13), "[\"Love Me Do\",\"From Me to You\",\"She Loves You\",\"I Want to Hold Your Hand\",\"Can\\u0027t Buy Me Love\",\"A Hard Day\\u0027s Night\",\"I Feel Fine\",\"Eight Days a Week\",\"Ticket to Ride\",\"Help!\",\"Yesterday\",\"Day Tripper\",\"We Can Work It Out\",\"Paperback Writer\",\"Yellow Submarine\",\"Eleanor Rigby\",\"Penny Lane\",\"All You Need Is Love\",\"Hello, Goodbye\",\"Lady Madonna\",\"Hey Jude\",\"Get Back\",\"The Ballad of John and Yoko\",\"Something\",\"Come Together\",\"Let It Be\",\"The Long and Winding Road\"]" },
                    { 17, "Celine Dion", "The fourth English-language studio album by Canadian singer Celine Dion.", "Pop", "Falling into You", 10, new DateOnly(1996, 3, 11), "[\"It\\u0027s All Coming Back to Me Now\",\"Because You Loved Me\",\"Falling into You\",\"Make You Happy\",\"Seduces Me\",\"All by Myself\",\"Declaration of Love\",\"(You Make Me Feel Like) A Natural Woman\",\"Dreamin\\u0027 of You\",\"I Love You\",\"If That\\u0027s What It Takes\",\"I Don\\u0027t Know\",\"River Deep, Mountain High\",\"Call the Man\",\"Fly\"]" },
                    { 18, "Celine Dion", "The fifth English-language studio album by Canadian singer Celine Dion.", "Pop", "Let's Talk About Love", 10, new DateOnly(1997, 11, 14), "[\"The Reason\",\"Immortality\",\"Treat Her Like a Lady\",\"Why Oh Why\",\"Love Is on the Way\",\"Tell Him\",\"Where Is the Love\",\"When I Need You\",\"Miles to Go (Before I Sleep)\",\"Us\",\"Just a Little Bit of Love\",\"My Heart Will Go On\",\"I Hate You Then I Love You\",\"To Love You More\",\"Let\\u0027s Talk About Love\"]" },
                    { 19, "The Beatles", "The eleventh studio album by the English rock band the Beatles.", "Rock", "Abbey Road", 10, new DateOnly(1969, 9, 26), "[\"Come Together\",\"Something\",\"Maxwell\\u0027s Silver Hammer\",\"Oh! Darling\",\"Octopus\\u0027s Garden\",\"I Want You (She\\u0027s So Heavy)\",\"Here Comes the Sun\",\"Because\",\"You Never Give Me Your Money\",\"Sun King\",\"Mean Mr. Mustard\",\"Polythene Pam\",\"She Came In Through the Bathroom Window\",\"Golden Slumbers\",\"Carry That Weight\",\"The End\",\"Her Majesty\"]" },
                    { 20, "Nirvana", "The second studio album by American rock band Nirvana.", "Grunge", "Nevermind", 10, new DateOnly(1991, 9, 24), "[\"Smells Like Teen Spirit\",\"In Bloom\",\"Come as You Are\",\"Breed\",\"Lithium\",\"Polly\",\"Territorial Pissings\",\"Drain You\",\"Lounge Act\",\"Stay Away\",\"On a Plain\",\"Something in the Way\",\"Endless, Nameless\"]" },
                    { 21, "Dire Straits", "The fifth studio album by British rock band Dire Straits.", "Roots Rock", "Brothers in Arms", 10, new DateOnly(1985, 5, 13), "[\"So Far Away\",\"Money for Nothing\",\"Walk of Life\",\"Your Latest Trick\",\"Why Worry\",\"Ride Across the River\",\"The Man\\u0027s Too Strong\",\"One World\",\"Brothers in Arms\"]" },
                    { 22, "Pink Floyd", "The eleventh studio album by the English rock band Pink Floyd.", "Progressive Rock", "The Wall", 10, new DateOnly(1979, 11, 30), "[\"In the Flesh?\",\"The Thin Ice\",\"Another Brick in the Wall, Part 1\",\"The Happiest Days of Our Lives\",\"Another Brick in the Wall, Part 2\",\"Mother\",\"Goodbye Blue Sky\",\"Empty Spaces\",\"Young Lust\",\"One of My Turns\",\"Don\\u0027t Leave Me Now\",\"Another Brick in the Wall, Part 3\",\"Goodbye Cruel World\",\"Hey You\",\"Is There Anybody Out There?\",\"Nobody Home\",\"Vera\",\"Bring the Boys Back Home\",\"Comfortably Numb\",\"The Show Must Go On\",\"In the Flesh\",\"Run Like Hell\",\"Waiting for the Worms\",\"Stop\",\"The Trial\",\"Outside the Wall\"]" },
                    { 23, "Santana", "The eighteenth studio album by Latin rock band Santana.", "Latin Rock", "Supernatural", 10, new DateOnly(1999, 6, 15), "[\"(Da Le) Yaleo\",\"Love of My Life\",\"Put Your Lights On\",\"Africa Bamba\",\"Smooth\",\"Do You Like the Way\",\"Maria Maria\",\"Migra\",\"Coraz\\u00F3n Espinado\",\"Wishing It Was\",\"El Farol\",\"Primavera\",\"The Calling\"]" },
                    { 24, "Guns N' Roses", "The debut studio album by American hard rock band Guns N' Roses.", "Hard Rock", "Appetite for Destruction", 10, new DateOnly(1987, 7, 21), "[\"Welcome to the Jungle\",\"It\\u0027s So Easy\",\"Nightrain\",\"Out ta Get Me\",\"Mr. Brownstone\",\"Paradise City\",\"My Michelle\",\"Think About You\",\"Sweet Child o\\u0027 Mine\",\"You\\u0027re Crazy\",\"Anything Goes\",\"Rocket Queen\"]" },
                    { 25, "ABBA", "A compilation album by the Swedish pop group ABBA.", "Pop, Disco", "Gold: Greatest Hits", 10, new DateOnly(1992, 9, 21), "[\"Dancing Queen\",\"Knowing Me, Knowing You\",\"Take a Chance on Me\",\"Mamma Mia\",\"Lay All Your Love on Me\",\"Super Trouper\",\"I Have a Dream\",\"The Winner Takes It All\",\"Money, Money, Money\",\"SOS\",\"Chiquitita\",\"Fernando\",\"Voulez-Vous\",\"Gimme! Gimme! Gimme! (A Man After Midnight)\",\"Does Your Mother Know\",\"One of Us\",\"The Name of the Game\",\"Thank You for the Music\",\"Waterloo\"]" },
                    { 26, "Bon Jovi", "The third studio album by American rock band Bon Jovi.", "Hard Rock, Glam Metal", "Slippery When Wet", 10, new DateOnly(1986, 8, 18), "[\"Let It Rock\",\"You Give Love a Bad Name\",\"Livin\\u0027 on a Prayer\",\"Social Disease\",\"Wanted Dead or Alive\",\"Raise Your Hands\",\"Without Love\",\"I\\u0027d Die for You\",\"Never Say Goodbye\",\"Wild in the Streets\"]" },
                    { 27, "Boston", "The debut studio album by American rock band Boston.", "Hard Rock", "Boston", 10, new DateOnly(1976, 8, 25), "[\"More Than a Feeling\",\"Peace of Mind\",\"Foreplay/Long Time\",\"Rock \\u0026 Roll Band\",\"Smokin\\u0027\",\"Hitch a Ride\",\"Something About You\",\"Let Me Take You Home Tonight\"]" },
                    { 28, "Linkin Park", "The debut studio album by American rock band Linkin Park.", "Nu Metal, Rap Rock", "Hybrid Theory", 10, new DateOnly(2000, 10, 24), "[\"Papercut\",\"One Step Closer\",\"With You\",\"Points of Authority\",\"Crawling\",\"Runaway\",\"By Myself\",\"In the End\",\"A Place for My Head\",\"Forgotten\",\"Cure for the Itch\",\"Pushing Me Away\"]" },
                    { 29, "Bob Marley and the Wailers", "A compilation album by Bob Marley and the Wailers.", "Reggae", "Legend", 10, new DateOnly(1984, 5, 8), "[\"Is This Love\",\"No Woman, No Cry\",\"Could You Be Loved\",\"Three Little Birds\",\"Buffalo Soldier\",\"Get Up, Stand Up\",\"Stir It Up\",\"Easy Skanking\",\"One Love/People Get Ready\",\"I Shot the Sheriff\",\"Waiting in Vain\",\"Redemption Song\",\"Satisfy My Soul\",\"Exodus\",\"Jamming\",\"Punky Reggae Party\"]" },
                    { 30, "Metallica", "The fifth studio album by American heavy metal band Metallica.", "Heavy Metal", "Metallica (The Black Album)", 10, new DateOnly(1991, 8, 12), "[\"Enter Sandman\",\"Sad but True\",\"Holier Than Thou\",\"The Unforgiven\",\"Wherever I May Roam\",\"Don\\u0027t Tread on Me\",\"Through the Never\",\"Nothing Else Matters\",\"Of Wolf and Man\",\"The God That Failed\",\"My Friend of Misery\",\"The Struggle Within\"]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
