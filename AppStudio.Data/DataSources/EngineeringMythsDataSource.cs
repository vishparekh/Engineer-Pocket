using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class EngineeringMythsDataSource : DataSourceBase<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{4ad06df1-ed2f-401e-9906-0e826eb330ca}",
                Content = "<ul><li><b><i>ENGINEERS ARE SUPER- HUMANS</i></b><i></i></li></ul><p>People do no" +
    "t understand the reality of ‘engineering.\' For them, engineers are “super-humans" +
    "” who build rockets, robots, electric vehicles and the like. The reason is that " +
    "when a person says he works on a satellite project, people jump to the conclusio" +
    "n that he knows every detail of building a satellite. In reality, no engineer ca" +
    "n know the entire details of projects. For example, it requires people from vari" +
    "ous disciplines such as electrical, mechanical, chemical and materials engineeri" +
    "ng to design an electric car.</p><p>Since the common man has the “super-human” v" +
    "iew in mind, he generally does not accept or appreciate many of the “real” engin" +
    "eering works. For example, a home inverter might not bring about any awe to the " +
    "common man as does an electric vehicle (though both might be equally challenging" +
    " to build), because he often finds a technician setting right the problems in a " +
    "home inverter. The technician just knows by experience what to do, whereas an en" +
    "gineer knows why it has to be done.</p><ul><li><i><b>ENGINEERING IS MORE VALUABL" +
    "E THAN SCIENCE</b></i></li></ul><p>First, I will clarify the difference between " +
    "‘science\' and ‘engineering\' through a simple example. The study of optics of mat" +
    "erials will fall under science. Scientists (physicists, in this case) will try t" +
    "o explain the optical properties which different materials possess. If someone t" +
    "ries to use the optical properties to make a microscope or a camera, he will be " +
    "an engineer. Scientists establish facts which engineers exploit to make things u" +
    "seful to society. History would tell you that scientists did a lot of engineerin" +
    "g work in the earlier days (between 1700 and 1900 when a lot of development real" +
    "ly happened in science and engineering).</p><p>Today, with the vastness of the d" +
    "ifferent fields, science and engineering have separated . Now, scientists rarely" +
    " take up engineering work. Nevertheless, I would say scientists play a greater r" +
    "ole as they have to establish the basic facts for engineers to build upon.</p><p" +
    ">Unfortunately, since the result of engineering is the one that fetches money, p" +
    "eople have a craze for engineering. It is disheartening to see a Ph.D. student i" +
    "n science getting a lesser stipend than a Ph.D. student in engineering. It shoul" +
    "d have been the other way round. Any nation that ignores the role of science can" +
    "not survive in the long run.</p><ul><li><i><b>MANAGEMENT STUDIES GOES WITH ENGIN" +
    "EERING</b></i></li></ul>A degree in engineering followed by a degree in Manageme" +
    "nt is the much sought-after combination. Again, a ‘myth\' that engineering and ma" +
    "nagement are related is at work. Engineering (with science as the basis) has not" +
    "hing to do with management (which does not involve science). A lucrative salary " +
    "is what attracts people to management studies.Furthermore, most institutes do no" +
    "t introduce engineering in a proper way, leaving students without confidence to " +
    "pursue higher education.<br><ul><li><b><i>WE NEED MORE IIT\'s</i></b></li></ul><p" +
    ">There are many IITs coming up, ostensibly to help the nation meet the requireme" +
    "nt of engineers. Truly speaking, we have enough of engineers. Design, the work o" +
    "f engineers, requires just a few people.</p><p>The dearth is not in the number b" +
    "ut in the quality of engineers we produce. It is enough if we are able to improv" +
    "e and maintain the quality of our institutes and retain the people graduating fr" +
    "om them by creating ample opportunities for them to work in India with a good sa" +
    "lary. It is better to improve and maintain the standards of the NITs, the IITs a" +
    "nd other government institutes than creating newer ones and diluting the existin" +
    "g standards.</p><ul><li><i><b>FOREIGN MNC S DO BEST R&amp;D ENGINEERING</b></i><" +
    "/li></ul><p>Foreign multinationals that claim to have research and development c" +
    "entres in India do not do real engineering work in the country, as it is natural" +
    " for any company to have real product development on home soil.</p><p>Here again" +
    ", the salary is what attracts people (thanks to the dollar-rupee conversion). Th" +
    "is is a case of brain drain, in which the brains are hired not to work. Though m" +
    "any might not accept, the basic aim of the foreign MNCs is to utilise the cheap " +
    "labour in the developing countries to run their manufacturing units; product dev" +
    "elopment is not their primary goal.</p><p>People generally end up doing tasks th" +
    "at are not as challenging as is the work in smaller Indian industries trying to " +
    "develop products of their own.</p>Engineering students do not study all the time" +
    ". We study most of the time. Relax, I merely jest. The number of hours recommend" +
    "ed for study and revision in engineering is similar to any other degree: 10 hour" +
    "s per course. So unless you’re doing a conjoint or accelerated pathway, you woul" +
    "d be taking four courses per semester, hence committing to a total of 40 hours o" +
    "f study per week, including your lecture times. So there’s plenty of time left f" +
    "or&nbsp;socializing&nbsp;and partaking in the wondrous activities of life. Some " +
    "of us join clubs for pastimes, some play sports, and others simply go to steins " +
    "and party. But all in all, maths problems&nbsp;aren’t&nbsp;the only things we en" +
    "gineering students do.<ul><li><i><b>A B.E/B.TECH GRADUATE IS AN ENGINEER</b></i>" +
    "</li></ul><p>With the vastness of technology, in the present day one cannot call" +
    " oneself an engineer just on graduating. A B.E./B.Tech. graduate knows just the " +
    "basics. I would say that post-graduation is a must. Or at least, one needs to wo" +
    "rk for a few years to understand and build engineering products. A lot of people" +
    " believe that a B.E. graduate in aerospace would be able to build rockets on gra" +
    "duating. If it were so, there would be rockets flying everywhere!</p><p>I would " +
    "advise people without an engineering background to talk to people who do real en" +
    "gineering work to take decisions before choosing the field for their children. T" +
    "he aim of education is not merely to land a high-paying job. It should empower y" +
    "ou to find a suitable work for yourself.</p><ul><li><b><i>ENGINEERING STUDENTS H" +
    "AVE NO SOCIAL LIVES</i></b></li></ul><span>Engineering students do not study all" +
    " the time. We study most of the time. Relax, I merely jest. The number of hours " +
    "recommended for study and revision in engineering is similar to any other degree" +
    ": 10 hours per course. So unless you’re doing a conjoint or accelerated pathway," +
    " you would be taking four courses per semester, hence committing to a total of 4" +
    "0 hours of study per week, including your lecture times. So there’s plenty of ti" +
    "me left for&nbsp;socializing&nbsp;and partaking in the wondrous activities of li" +
    "fe. Some of us join clubs for pastimes, some play sports, and others simply go t" +
    "o steins and party. But all in all, maths problems&nbsp;aren’t&nbsp;the only thi" +
    "ngs we engineering students do.<br></span><ul><li><b><i>THE LECTURES START FROM " +
    "SCRATCH</i></b></li></ul><span>I was told in high school that once you get to un" +
    "iversity, the lecturers would go through all the high school calculus and physic" +
    "s again from scratch, but that’s far from reality. The theories we were taught a" +
    "nd the problems we were given were based on a solid high school foundation. If t" +
    "hat&nbsp;doesn’t&nbsp;raise concern, keep reading. After only two and a half wee" +
    "ks into engineering, we were given a basic skills test from the mathematical mod" +
    "elling course which&nbsp;trialed&nbsp;our knowledge on all aspects of high schoo" +
    "l calculus, and the final grade counts toward the first year GPA! So study hard " +
    "now while you have plenty of time!<br></span><ul><li><b><i>ENGINEERING STUDENTS " +
    "USE A LOT OF TECHNOLOGY</i></b></li></ul><p>I was excited to see a couple of mic" +
    "rowaves in the engineering cafeteria, only to find out that one was broken a yea" +
    "r ago, and the other, two years ago. One would think that someone in the enginee" +
    "ring department would know how to fix a microwave, or at least know where to fin" +
    "d someone who knows how to fix a microwave. Though to be fair, the microwaves in" +
    " SciSpace were removed due to construction, and as far as I know, the other facu" +
    "lties don’t even have microwaves. At least we have a couple on display.</p><p>Al" +
    "so, being engineering students, you’d expect us to have our lectures in the gran" +
    "d engineering building, but none of our first year lectures are actually in the " +
    "engineering building. Instead, we were split off into the old science building a" +
    "nd the even older looking human sciences building, devoid of wifi access. Perhap" +
    "s it’s a scheme to keep us first years focused during lectures, but the experien" +
    "ce so far has been painful, especially for those with Compulsive Facebooking Syn" +
    "drome.</p><ul><li><b><i>THERE ARE NO GIRLS IN ENGINEERING</i></b>&nbsp;</li></ul" +
    "><p>Contrary to popular belief, girls do study engineering. In fact, the percent" +
    "age of girls studying engineering is higher than ever, and still on the rise. So" +
    " if you’re a girl hesitant to study engineering because you fear of being an out" +
    "cast, hesitate no longer, for you will fit in and make wonderful friends. And mo" +
    "st of the time it’ll actually be easier for you than for the guys as you’ll rece" +
    "ive so much support from organizations such as Women in Engineering, which organ" +
    "izes events especially for girls to make friends and network.<br></p><ul><li><b>" +
    "<i>ENGINEERING IS SO DIFFICULT THAT ITS DAMAGING TO OUR HEALTH</i></b></li></ul>" +
    "<p>Engineering students are actually quite relaxed. Though the coursework may be" +
    " difficult, there is no pressure to outcompete one another, much in contrast to " +
    "the pre-med students with their swords of pens and shields of books. Have you se" +
    "en those biomed and health sci students entering their lecture halls? It’s reall" +
    "y quite a spectacle. The noise they make resemble the war cries of ancient tribe" +
    "s, while their movement remind me of stampedes of wild elephants. As engineering" +
    " students do not need to undergo natural selection after making it into first ye" +
    "ar, we tend to stroll in calmly as the lecturer plays some music or videos for p" +
    "leasure, which I believe is better for our psychological state. Plus, any remain" +
    "ing pressure you feel will be completely eradicated after the entertainment prov" +
    "ided by our lecturers.&nbsp;<br></p><ul><li><i></i></li></ul>"
            }
        };

        protected override string CacheKey
        {
            get { return "EngineeringMythsDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        public async override Task<IEnumerable<HtmlSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
