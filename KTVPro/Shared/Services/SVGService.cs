using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shared.Services
{
    public class SVGService
    {
        public RenderFragment CrossIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 32 32""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M18.8,16l5.5-5.5c0.8-0.8,0.8-2,0-2.8l0,0C24,7.3,23.5,7,23,7c-0.5,0-1,0.2-1.4,0.6L16,13.2l-5.5-5.5 c-0.8-0.8-2.1-0.8-2.8,0C7.3,8,7,8.5,7,9.1s0.2,1,0.6,1.4l5.5,5.5l-5.5,5.5C7.3,21.9,7,22.4,7,23c0,0.5,0.2,1,0.6,1.4 C8,24.8,8.5,25,9,25c0.5,0,1-0.2,1.4-0.6l5.5-5.5l5.5,5.5c0.8,0.8,2.1,0.8,2.8,0c0.8-0.8,0.8-2.1,0-2.8L18.8,16z""></path> </g>
                    </svg>
                ", w, h));
            };
        }

        public RenderFragment HeartUnfill(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M1 8.5C1 5.21475 3.31333 2 7 2C8.70883 2 9.92877 2.48125 10.8649 3.2079C11.3091 3.55266 11.6802 3.94929 11.9974 4.33639C12.311 3.95011 12.6785 3.55357 13.1186 3.20977C14.0531 2.47979 15.275 2 17 2C20.7289 2 23 5.22013 23 8.5C23 11.8412 21.3259 14.6994 19.2285 16.9297C17.1279 19.1634 14.523 20.8565 12.4472 21.8944C12.1657 22.0352 11.8343 22.0352 11.5528 21.8944C9.47698 20.8565 6.8721 19.1634 4.77151 16.9297C2.67415 14.6994 1 11.8412 1 8.5ZM7 4C4.68667 4 3 6.02986 3 8.5C3 11.1445 4.32585 13.5363 6.22849 15.5596C7.9833 17.4256 10.1612 18.9027 12 19.8754C13.8388 18.9027 16.0167 17.4256 17.7715 15.5596C19.6741 13.5363 21 11.1445 21 8.5C21 6.02448 19.3463 4 17 4C15.6874 4 14.907 4.35067 14.3497 4.78592C13.8333 5.18934 13.4736 5.68102 13.045 6.26703C12.9669 6.37374 12.8866 6.48357 12.8026 6.59656C12.6139 6.85039 12.3163 7 12 7C11.6837 7 11.3861 6.85039 11.1974 6.59656C11.1256 6.49997 11.0562 6.4055 10.9884 6.31318C10.5465 5.71179 10.1717 5.20159 9.63856 4.78779C9.07355 4.34922 8.29117 4 7 4Z"" fill=""currentcolor""></path> </g></svg>
                ", w, h));
            };
        }
        public RenderFragment HeartFill(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 64 64"" version=""1.1"" xml:space=""preserve"" style=""fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""Icons"" x=""-64"" y=""-256"" width=""1280"" height=""800"" style=""fill:none;""></rect> <g id=""Icons1"" serif:id=""Icons""> <g id=""Strike""> </g> <g id=""H1""> </g> <g id=""H2""> </g> <g id=""H3""> </g> <g id=""list-ul""> </g> <g id=""hamburger-1""> </g> <g id=""hamburger-2""> </g> <g id=""list-ol""> </g> <g id=""list-task""> </g> <g id=""trash""> </g> <g id=""vertical-menu""> </g> <g id=""horizontal-menu""> </g> <g id=""sidebar-2""> </g> <g id=""Pen""> </g> <g id=""Pen1"" serif:id=""Pen""> </g> <g id=""clock""> </g> <g id=""external-link""> </g> <g id=""hr""> </g> <g id=""info""> </g> <g id=""warning""> </g> <g id=""plus-circle""> </g> <g id=""minus-circle""> </g> <g id=""vue""> </g> <g id=""cog""> </g> <g id=""logo""> </g> <path d=""M43.046,9.05c5.137,0.117 9.856,3.451 11.782,8.485c2.392,6.249 0.678,13.452 -2.495,19.624c-3.792,7.375 -10.79,12.703 -17.966,17.288c0,0 -2.796,1.351 -5.516,-0.403c-9.246,-6.021 -17.877,-13.963 -20.318,-24.82c-1.857,-8.258 1.161,-18.596 10.582,-20.034c4.72,-0.721 11.109,2.766 12.808,5.869c1.657,-3.095 6.565,-5.884 10.694,-6.008c0.215,-0.002 0.214,-0.003 0.429,-0.001Z"" style=""fill-rule:nonzero;""></path> <g id=""radio-check""> </g> <g id=""eye-slash""> </g> <g id=""eye""> </g> <g id=""toggle-off""> </g> <g id=""shredder""> </g> <g id=""spinner--loading--dots-"" serif:id=""spinner [loading, dots]""> </g> <g id=""react""> </g> <g id=""check-selected""> </g> <g id=""turn-off""> </g> <g id=""code-block""> </g> <g id=""user""> </g> <g id=""coffee-bean""> </g> <g id=""coffee-beans""> <g id=""coffee-bean1"" serif:id=""coffee-bean""> </g> </g> <g id=""coffee-bean-filled""> </g> <g id=""coffee-beans-filled""> <g id=""coffee-bean2"" serif:id=""coffee-bean""> </g> </g> <g id=""clipboard""> </g> <g id=""clipboard-paste""> </g> <g id=""clipboard-copy""> </g> <g id=""Layer1""> </g> </g> </g></svg>
                ", w, h));
            };
        }
        public RenderFragment CarvonDown(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 32 32"" version=""1.1"" ><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M0.256 8.606c0-0.269 0.106-0.544 0.313-0.75 0.412-0.412 1.087-0.412 1.5 0l14.119 14.119 13.913-13.912c0.413-0.412 1.087-0.412 1.5 0s0.413 1.088 0 1.5l-14.663 14.669c-0.413 0.413-1.088 0.413-1.5 0l-14.869-14.869c-0.213-0.213-0.313-0.481-0.313-0.756z""></path> </g></svg>
                ", w, h));
            };
        }
        public RenderFragment ArrowBackIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g>
                        <g id=""SVGRepo_iconCarrier""> <path d=""M6 12H18M6 12L11 7M6 12L11 17"" stroke=""currentcolor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""></path> </g>
                     </svg>
                ", w, h));
            };
        }

        public RenderFragment EditIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	           <svg width=""{0}"" height=""{1}"" viewBox=""0 0 20 20"" fill=""currentcolor"" transform=""matrix(-1, 0, 0, 1, 0, 0)""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""><path d=""M14.846 1.403l3.752 3.753.625-.626A2.653 2.653 0 0015.471.778l-.625.625zm2.029 5.472l-3.752-3.753L1.218 15.028 0 19.998l4.97-1.217L16.875 6.875z"" fill=""currentcolor""></path></g></svg>
                ", w, h));
            };
        }
        public RenderFragment LogOutIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	          <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M8.00195 7C8.01406 4.82497 8.11051 3.64706 8.87889 2.87868C9.75757 2 11.1718 2 14.0002 2H15.0002C17.8286 2 19.2429 2 20.1215 2.87868C21.0002 3.75736 21.0002 5.17157 21.0002 8V16C21.0002 18.8284 21.0002 20.2426 20.1215 21.1213C19.2429 22 17.8286 22 15.0002 22H14.0002C11.1718 22 9.75757 22 8.87889 21.1213C8.11051 20.3529 8.01406 19.175 8.00195 17"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-linecap=""round""></path> <path d=""M8 19.5C5.64298 19.5 4.46447 19.5 3.73223 18.7678C3 18.0355 3 16.857 3 14.5V9.5C3 7.14298 3 5.96447 3.73223 5.23223C4.46447 4.5 5.64298 4.5 8 4.5"" stroke=""currentcolor"" stroke-width=""1.5""></path> <path d=""M15 12L6 12M6 12L8 14M6 12L8 10"" stroke=""#1C274C"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round""></path> </g></svg>
                ", w, h));
            };
        }

        public RenderFragment VisibleIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	          <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 64 64"" version=""1.1"" xml:space=""preserve""  style=""fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""Icons"" x=""-896"" y=""-256"" width=""1280"" height=""800"" style=""fill:none;""></rect> <g id=""Icons1"" serif:id=""Icons""> <g id=""Strike""> </g> <g id=""H1""> </g> <g id=""H2""> </g> <g id=""H3""> </g> <g id=""list-ul""> </g> <g id=""hamburger-1""> </g> <g id=""hamburger-2""> </g> <g id=""list-ol""> </g> <g id=""list-task""> </g> <g id=""trash""> </g> <g id=""vertical-menu""> </g> <g id=""horizontal-menu""> </g> <g id=""sidebar-2""> </g> <g id=""Pen""> </g> <g id=""Pen1"" serif:id=""Pen""> </g> <g id=""clock""> </g> <g id=""external-link""> </g> <g id=""hr""> </g> <g id=""info""> </g> <g id=""warning""> </g> <g id=""plus-circle""> </g> <g id=""minus-circle""> </g> <g id=""vue""> </g> <g id=""cog""> </g> <g id=""logo""> </g> <g id=""radio-check""> </g> <g id=""eye-slash""> </g> <g id=""eye""> <path d=""M32.513,13.926c10.574,0.15 19.141,9.894 23.487,18.074c0,0 -1.422,2.892 -2.856,4.895c-0.694,0.969 -1.424,1.913 -2.191,2.826c-0.547,0.65 -1.112,1.283 -1.698,1.898c-5.237,5.5 -12.758,9.603 -20.7,8.01c-8.823,-1.77 -15.732,-9.498 -20.058,-17.629c0,0 1.248,-2.964 2.69,-4.964c0.646,-0.897 1.324,-1.77 2.034,-2.617c0.544,-0.649 1.108,-1.282 1.691,-1.897c4.627,-4.876 10.564,-8.63 17.601,-8.596Zm-0.037,4c-5.89,-0.022 -10.788,3.267 -14.663,7.35c-0.527,0.555 -1.035,1.127 -1.527,1.713c-0.647,0.772 -1.265,1.569 -1.854,2.386c-0.544,0.755 -1.057,1.805 -1.451,2.59c3.773,6.468 9.286,12.323 16.361,13.742c6.563,1.317 12.688,-2.301 17.016,-6.846c0.529,-0.555 1.04,-1.128 1.534,-1.715c0.7,-0.833 1.366,-1.694 1.999,-2.579c0.557,-0.778 1.144,-1.767 1.588,-2.567c-3.943,-6.657 -10.651,-13.944 -19.003,-14.074Z""></path> <path d=""M32.158,23.948c4.425,0 8.018,3.593 8.018,8.017c0,4.425 -3.593,8.017 -8.018,8.017c-4.424,0 -8.017,-3.592 -8.017,-8.017c0,-4.424 3.593,-8.017 8.017,-8.017Zm0,4.009c2.213,0 4.009,1.796 4.009,4.008c0,2.213 -1.796,4.009 -4.009,4.009c-2.212,0 -4.008,-1.796 -4.008,-4.009c0,-2.212 1.796,-4.008 4.008,-4.008Z""></path> </g> <g id=""toggle-off""> </g> <g id=""shredder""> </g> <g id=""spinner--loading--dots-"" serif:id=""spinner [loading, dots]""> </g> <g id=""react""> </g> <g id=""check-selected""> </g> <g id=""turn-off""> </g> <g id=""code-block""> </g> <g id=""user""> </g> <g id=""coffee-bean""> </g> <g id=""coffee-beans""> <g id=""coffee-bean1"" serif:id=""coffee-bean""> </g> </g> <g id=""coffee-bean-filled""> </g> <g id=""coffee-beans-filled""> <g id=""coffee-bean2"" serif:id=""coffee-bean""> </g> </g> <g id=""clipboard""> </g> <g id=""clipboard-paste""> </g> <g id=""clipboard-copy""> </g> <g id=""Layer1""> </g> </g> </g></svg>
                ", w, h));
            };
        }

        public RenderFragment InVisibleIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	          <svg fill=""currentcolor"" width=""{1}"" height=""{1}"" viewBox=""0 0 64 64"" version=""1.1"" xml:space=""preserve"" style=""fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""Icons"" x=""-960"" y=""-256"" width=""1280"" height=""800"" style=""fill:none;""></rect> <g id=""Icons1"" serif:id=""Icons""> <g id=""Strike""> </g> <g id=""H1""> </g> <g id=""H2""> </g> <g id=""H3""> </g> <g id=""list-ul""> </g> <g id=""hamburger-1""> </g> <g id=""hamburger-2""> </g> <g id=""list-ol""> </g> <g id=""list-task""> </g> <g id=""trash""> </g> <g id=""vertical-menu""> </g> <g id=""horizontal-menu""> </g> <g id=""sidebar-2""> </g> <g id=""Pen""> </g> <g id=""Pen1"" serif:id=""Pen""> </g> <g id=""clock""> </g> <g id=""external-link""> </g> <g id=""hr""> </g> <g id=""info""> </g> <g id=""warning""> </g> <g id=""plus-circle""> </g> <g id=""minus-circle""> </g> <g id=""vue""> </g> <g id=""cog""> </g> <g id=""logo""> </g> <g id=""radio-check""> </g> <g id=""eye-slash""> <path d=""M13.673,10.345l-3.097,3.096l39.853,39.854l3.097,-3.097l-39.853,-39.853Z""></path> <path d=""M17.119,19.984l2.915,2.915c-3.191,2.717 -5.732,6.099 -7.374,9.058l-0.005,0.01c4.573,7.646 11.829,14.872 20.987,13.776c2.472,-0.296 4.778,-1.141 6.885,-2.35l2.951,2.95c-4.107,2.636 -8.815,4.032 -13.916,3.342c-9.198,-1.244 -16.719,-8.788 -21.46,-17.648c2.226,-4.479 5.271,-8.764 9.017,-12.053Zm6.63,-4.32c2.572,-1.146 5.355,-1.82 8.327,-1.868c0.165,-0.001 2.124,0.092 3.012,0.238c0.557,0.092 1.112,0.207 1.659,0.35c8.725,2.273 15.189,10.054 19.253,17.653c-1.705,3.443 -3.938,6.398 -6.601,9.277l-2.827,-2.827c1.967,-2.12 3.622,-4.161 4.885,-6.45c0,0 -1.285,-2.361 -2.248,-3.643c-0.619,-0.824 -1.27,-1.624 -1.954,-2.395c-0.54,-0.608 -2.637,-2.673 -3.136,-3.103c-3.348,-2.879 -7.279,-5.138 -11.994,-5.1c-1.826,0.029 -3.582,0.389 -5.249,0.995l-3.127,-3.127Z"" style=""fill-rule:nonzero;""></path> <path d=""M25.054,27.92l2.399,2.398c-0.157,0.477 -0.243,0.987 -0.243,1.516c0,2.672 2.169,4.841 4.841,4.841c0.529,0 1.039,-0.085 1.516,-0.243l2.399,2.399c-1.158,0.65 -2.494,1.02 -3.915,1.02c-4.425,0 -8.017,-3.592 -8.017,-8.017c0,-1.421 0.371,-2.756 1.02,-3.914Zm6.849,-4.101c0.049,-0.001 0.099,-0.002 0.148,-0.002c4.425,0 8.017,3.593 8.017,8.017c0,0.05 0,0.099 -0.001,0.148l-8.164,-8.163Z""></path> </g> <g id=""eye""> </g> <g id=""toggle-off""> </g> <g id=""shredder""> </g> <g id=""spinner--loading--dots-"" serif:id=""spinner [loading, dots]""> </g> <g id=""react""> </g> <g id=""check-selected""> </g> <g id=""turn-off""> </g> <g id=""code-block""> </g> <g id=""user""> </g> <g id=""coffee-bean""> </g> <g id=""coffee-beans""> <g id=""coffee-bean1"" serif:id=""coffee-bean""> </g> </g> <g id=""coffee-bean-filled""> </g> <g id=""coffee-beans-filled""> <g id=""coffee-bean2"" serif:id=""coffee-bean""> </g> </g> <g id=""clipboard""> </g> <g id=""clipboard-paste""> </g> <g id=""clipboard-copy""> </g> <g id=""Layer1""> </g> </g> </g></svg>
                ", w, h));
            };
        }

        public RenderFragment WarningIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	              <svg width=""{0}"" height=""{1}"" viewBox=""0 0 1024 1024"" fill=""currentcolor"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g>
                        <g id=""SVGRepo_iconCarrier""><path fill=""currentcolor"" d=""M512 64a448 448 0 1 1 0 896 448 448 0 0 1 0-896zm0 192a58.432 58.432 0 0 0-58.24 63.744l23.36 256.384a35.072 35.072 0 0 0 69.76 0l23.296-256.384A58.432 58.432 0 0 0 512 256zm0 512a51.2 51.2 0 1 0 0-102.4 51.2 51.2 0 0 0 0 102.4z""></path></g>
                      </svg>
                ", w, h));
            };
        }

        public RenderFragment RecentIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	             <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" id=""_24x24_On_Light_Recent"" data-name=""24x24/On Light/Recent"" fill=""currentcolor78""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""view-box"" width=""24"" height=""24"" fill=""none""></rect> <path id=""Shape"" d=""M9.682,18.75a.75.75,0,0,1,.75-.75,8.25,8.25,0,1,0-6.189-2.795V12.568a.75.75,0,0,1,1.5,0v4.243a.75.75,0,0,1-.751.75H.75a.75.75,0,0,1,0-1.5H3a9.75,9.75,0,1,1,7.433,3.44A.75.75,0,0,1,9.682,18.75Zm2.875-4.814L9.9,11.281a.754.754,0,0,1-.22-.531V5.55a.75.75,0,1,1,1.5,0v4.889l2.436,2.436a.75.75,0,1,1-1.061,1.06Z"" transform=""translate(1.568 2.25)"" fill=""currentcolor""></path> </g></svg>
                ", w, h));
            };
        }

        public RenderFragment TrashIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"" ><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M3 6.38597C3 5.90152 3.34538 5.50879 3.77143 5.50879L6.43567 5.50832C6.96502 5.49306 7.43202 5.11033 7.61214 4.54412C7.61688 4.52923 7.62232 4.51087 7.64185 4.44424L7.75665 4.05256C7.8269 3.81241 7.8881 3.60318 7.97375 3.41617C8.31209 2.67736 8.93808 2.16432 9.66147 2.03297C9.84457 1.99972 10.0385 1.99986 10.2611 2.00002H13.7391C13.9617 1.99986 14.1556 1.99972 14.3387 2.03297C15.0621 2.16432 15.6881 2.67736 16.0264 3.41617C16.1121 3.60318 16.1733 3.81241 16.2435 4.05256L16.3583 4.44424C16.3778 4.51087 16.3833 4.52923 16.388 4.54412C16.5682 5.11033 17.1278 5.49353 17.6571 5.50879H20.2286C20.6546 5.50879 21 5.90152 21 6.38597C21 6.87043 20.6546 7.26316 20.2286 7.26316H3.77143C3.34538 7.26316 3 6.87043 3 6.38597Z"" fill=""currentcolor""></path> <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M11.5956 22.0001H12.4044C15.1871 22.0001 16.5785 22.0001 17.4831 21.1142C18.3878 20.2283 18.4803 18.7751 18.6654 15.8686L18.9321 11.6807C19.0326 10.1037 19.0828 9.31524 18.6289 8.81558C18.1751 8.31592 17.4087 8.31592 15.876 8.31592H8.12404C6.59127 8.31592 5.82488 8.31592 5.37105 8.81558C4.91722 9.31524 4.96744 10.1037 5.06788 11.6807L5.33459 15.8686C5.5197 18.7751 5.61225 20.2283 6.51689 21.1142C7.42153 22.0001 8.81289 22.0001 11.5956 22.0001ZM10.2463 12.1886C10.2051 11.7548 9.83753 11.4382 9.42537 11.4816C9.01321 11.525 8.71251 11.9119 8.75372 12.3457L9.25372 17.6089C9.29494 18.0427 9.66247 18.3593 10.0746 18.3159C10.4868 18.2725 10.7875 17.8856 10.7463 17.4518L10.2463 12.1886ZM14.5746 11.4816C14.9868 11.525 15.2875 11.9119 15.2463 12.3457L14.7463 17.6089C14.7051 18.0427 14.3375 18.3593 13.9254 18.3159C13.5132 18.2725 13.2125 17.8856 13.2537 17.4518L13.7537 12.1886C13.7949 11.7548 14.1625 11.4382 14.5746 11.4816Z"" fill=""currentcolor""></path> </g></svg>
                ", w, h));
            };
        }

        public RenderFragment PhoneIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	              <svg width=""{0}"" height=""{1}"" viewBox=""0 0 20 20"" version=""1.1""  fill=""currentcolor""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <title>call [#191]</title> <desc>Created with Sketch.</desc> <defs> </defs> <g id=""Page-1"" stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd""> <g id=""Dribbble-Light-Preview"" transform=""translate(-140.000000, -7319.000000)"" fill=""#00e2e6""> <g id=""icons"" transform=""translate(56.000000, 160.000000)""> <path d=""M94,7167 L94,7169 L96,7169 C96,7167.895 95.105,7167 94,7167 M94,7163 L94,7165 C96.206,7165 98,7166.794 98,7169 L100,7169 C100,7165.686 97.314,7163 94,7163 M94,7159 L94,7161 C98.411,7161 102,7164.589 102,7169 L104,7169 C104,7163.477 99.523,7159 94,7159 M98.652,7177.234 C98.641,7177.265 98.64,7177.27 98.652,7177.234 M98.117,7174.578 C97.422,7174.204 96.719,7173.778 95.992,7173.481 C94.587,7172.908 94.682,7174.602 93.679,7175.151 C93.027,7175.508 92.107,7174.861 91.538,7174.503 C90.544,7173.877 89.663,7173.053 88.931,7172.1 C88.556,7171.613 87.728,7170.697 87.83,7170.014 C87.992,7168.93 89.274,7168.876 88.907,7167.55 C88.711,7166.84 88.36,7166.141 88.097,7165.457 C87.745,7164.54 87.6,7163.953 86.573,7164.003 C85.831,7164.039 85.339,7164.356 84.883,7164.951 C83.649,7166.558 83.835,7168.725 84.664,7170.488 C85.838,7172.983 87.85,7175.335 89.999,7176.855 C91.461,7177.889 93.387,7178.828 95.157,7178.987 C96.453,7179.104 98.266,7178.403 98.73,7176.996 C98.698,7177.094 98.667,7177.189 98.652,7177.234 C98.663,7177.199 98.687,7177.128 98.73,7176.996 C98.777,7176.854 98.8,7176.783 98.811,7176.751 C98.797,7176.793 98.765,7176.891 98.731,7176.993 C99.139,7175.753 99.189,7175.155 98.117,7174.578 M98.811,7176.751 C98.819,7176.727 98.819,7176.725 98.811,7176.751"" id=""call-[#191]""> </path> </g> </g> </g> </g>
                    </svg>
                ", w, h));
            };
        }
    }
}
